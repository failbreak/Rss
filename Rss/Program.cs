using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

XDocument.Load("https://www.dr.dk/nyheder/service/feeds/senestenyt").Root
    .Element("channel")
    .Elements("item")
    .Select(x => new
    {
        Title = x.Element("title").Value,
        Link = x.Element("link").Value,
        Dato = x.Element("pubDate").Value
    })
    .ToList()
    .ForEach(x => { Console.WriteLine($"\n {x.Title} \n \t :{x.Link}: \n \t \t {x.Dato} \n"); });
