﻿using System;
using System.Collections.Generic;

namespace Section_05_03
{
    class Program
    {
        static void Main()
        {
            var inventory = new List<InventoryItem>
            {
                new InventoryItem
                {
                    PartNumber = "1",
                    Description = "Part #1",
                    Count = 3,
                    ItemPrice = 5.26m
                },
                new InventoryItem
                {
                    PartNumber = "2",
                    Description = "Part #2",
                    Count = 1,
                    ItemPrice = 7.95m
                },
                new InventoryItem
                {
                    PartNumber = "3",
                    Description = "Part #3",
                    Count = 2,
                    ItemPrice = 23.13m
                },
            };

            string report =
                new Report<InventoryItem>()
                .Generate(inventory, ReportType.Markdown);

            Console.WriteLine(report);
        }
    }
}
