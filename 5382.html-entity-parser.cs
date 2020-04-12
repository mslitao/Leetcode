using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5382
{
    /*
Quotation Mark: the entity is &quot; and symbol character is ".
Single Quote Mark: the entity is &apos; and symbol character is '.
Ampersand: the entity is &amp; and symbol character is &.
Greater Than Sign: the entity is &gt; and symbol character is >.
Less Than Sign: the entity is &lt; and symbol character is <.
Slash: the entity is &frasl; and symbol character is /.
    */
    public string EntityParser(string text) {
        if(string.IsNullOrEmpty(text)) return text;
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("&quot", "\"");
        map.Add("&apos", "'");
        map.Add("&amp", "&");
        map.Add("&gt", ">");
        map.Add("&lt", "<");
        map.Add("&frasl", "/");

        foreach(var item in map)
        {
            text = text.Replace(item.Key, item.Value);
        }

        return text;
    }
}