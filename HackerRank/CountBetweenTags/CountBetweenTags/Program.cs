using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string html = Console.ReadLine();//"<div>abcd</div><div><h1>tyru</h1><p>yyuu</p><p>ksksj js</p> test cont</div>";

        // Dictionary to hold tag names and their content lengths
        var tagCounts = new Dictionary<string, int>();

        // Regex to match opening and closing tags
        var tagRegex = new Regex(@"<\/?(\w+)[^>]*>", RegexOptions.Compiled);

        // To keep track of the current tag we're inside of
        var tagStack = new Stack<string>();

        // To accumulate the text content of the current tag
        var currentTagContent = new Dictionary<string, List<char>>();

        // Position in the input string
        int currentIndex = 0;

        // Iterate through the HTML string
        while (currentIndex < html.Length)
        {
            var tagMatch = tagRegex.Match(html, currentIndex);
            if (tagMatch.Success)
            {
                // Process text content before this tag
                if (currentIndex < tagMatch.Index)
                {
                    var textContent = html.Substring(currentIndex, tagMatch.Index - currentIndex);
                    if (tagStack.Count > 0)
                    {
                        var currentTag = tagStack.Peek();
                        if (!currentTagContent.ContainsKey(currentTag))
                        {
                            currentTagContent[currentTag] = new List<char>();
                        }
                        currentTagContent[currentTag].AddRange(textContent);
                    }
                }

                // Process the tag
                var tagName = tagMatch.Groups[1].Value;
                if (html[tagMatch.Index] == '<' && html[tagMatch.Index + 1] == '/')
                {
                    // Closing tag
                    if (tagStack.Count > 0 && tagStack.Peek() == tagName)
                    {
                        tagStack.Pop();
                    }
                }
                else
                {
                    // Opening tag
                    tagStack.Push(tagName);
                }

                // Move past the tag
                currentIndex = tagMatch.Index + tagMatch.Length;
            }
            else
            {
                // No more tags, process remaining text content
                if (currentIndex < html.Length)
                {
                    var textContent = html.Substring(currentIndex);
                    if (tagStack.Count > 0)
                    {
                        var currentTag = tagStack.Peek();
                        if (!currentTagContent.ContainsKey(currentTag))
                        {
                            currentTagContent[currentTag] = new List<char>();
                        }
                        currentTagContent[currentTag].AddRange(textContent);
                    }
                }
                break;
            }
        }

        // Calculate the length of content for each tag
        foreach (var tag in currentTagContent)
        {
            var tagName = tag.Key;
            var contentLength = tag.Value.Count;
            if (tagCounts.ContainsKey(tagName))
            {
                tagCounts[tagName] += contentLength;
            }
            else
            {
                tagCounts[tagName] = contentLength;
            }
        }

        // Print the results
        foreach (var tag in tagCounts)
        {
            Console.WriteLine($"{tag.Key}: {tag.Value}");
        }
    }
}

