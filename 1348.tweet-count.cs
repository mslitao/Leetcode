using System;
using System.Collections.Generic;
using System.Linq;

class SolutionTweet
{
    static void Main1(string[] args)
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello, World");
        }
        
        TweetCounts tweetCounts = new TweetCounts();
        tweetCounts.RecordTweet("tweet3", 0);
        tweetCounts.RecordTweet("tweet3", 60);
        tweetCounts.RecordTweet("tweet3", 10);                            
        Console.WriteLine(String.Join("-",tweetCounts.GetTweetCountsPerFrequency("minute", "tweet3", 0, 59)));
        Console.WriteLine(String.Join("-",tweetCounts.GetTweetCountsPerFrequency("minute", "tweet3", 0, 60)));
        tweetCounts.RecordTweet("tweet3", 120);                            
        Console.WriteLine(String.Join("-",tweetCounts.GetTweetCountsPerFrequency("hour", "tweet3", 0, 210)));
    }
}
public class TweetCounts {
    Dictionary<string, List<int>> records= new Dictionary<string, List<int>>();

    public TweetCounts() 
    {
        records= new Dictionary<string, List<int>>();
    }
    
    // time in seconds
    public void RecordTweet(string tweetName, int time) 
    {
        if(!records.ContainsKey(tweetName))
        {
            records.Add(tweetName, new List<int>());
        }
        var items = records[tweetName];
        items.Add(time);
        records[tweetName]= items;
    }
    
    //minute, hour, or day
    public IList<int> GetTweetCountsPerFrequency(string freq, string tweetName, int startTime, int endTime)     {
        if(startTime >  endTime) return null;        
        int unit = 0;
        if(freq == "minute")
        {
            unit = 60;
        }
        else if(freq == "hour")
        {
            unit = 60* 60;
        }
        else if(freq == "day")
        {
            unit = 60 * 60 * 24;
        }
        
        IList<int> results = new List<int>();
        
        
        List<int> items = null;
        if(records.ContainsKey(tweetName))
        {
            items = records[tweetName];
        }
        else
        {
            return null;
        }

        while(startTime <= endTime)
        {
            int cnt = 0;
            foreach(var item in items)
            {
                if(item >= startTime && item < (startTime + unit) && item <= endTime)
                    cnt ++;
            }
                
            results.Add(cnt);

            startTime = startTime +  unit ;
        }
        
        return results;
    }
}