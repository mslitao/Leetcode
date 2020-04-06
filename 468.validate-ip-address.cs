using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution468
{
    
    public string ValidIPAddress(string IP) 
    {
        if (IsIp4(IP)) return "IPv4"; 
        if (IsIp6(IP)) return "IPv6";  
        return "Neither";
    }
    
    private bool IsIp4(string s)
    {
        string[] parts = s.Split(new char[] { '.' });
        if (parts.Length != 4) return false;
        
        int x = 0;
        foreach (string p in parts)
        {
            if (!Int32.TryParse(p, out x)) return false;
            if(x < 0 || x > 255 || (x.ToString().Length != p.Length)) return false;
        }
        return true;
    }
    
    private bool IsIp6(string s)
    {
        string[] parts = s.Split(new char[] { ':' });
        if (parts.Length != 8) return false;
        
        int x = 0;
        foreach (string p in parts)
        {                
            if (p.Length > 4) return false;
            
            if (!Int32.TryParse(
                    p, 
                    System.Globalization.NumberStyles.HexNumber, 
                    System.Globalization.CultureInfo.InvariantCulture, 
                    out x)) return false;
                    
            if(x < 0) return false;
        }
        return true;
    }
}