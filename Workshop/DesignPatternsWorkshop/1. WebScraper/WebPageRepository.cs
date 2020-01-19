﻿namespace WebScraper
{
    using System.Collections.Generic;

    public sealed class WebPageRepository
    {
        private Queue<string> addresses;
        private static WebPageRepository instance;
        private static readonly object obj = new object();

        private WebPageRepository()
        {
            this.addresses = new Queue<string>();
            this.Seed();
        }

        public static WebPageRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new WebPageRepository();
                    }
                }

                return instance;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return this.addresses.Count == 0;
            }
        }

        public void Add(string address)
        {
            this.addresses.Enqueue(address);
        }

        public string Remove()
        {
            return this.addresses.Dequeue();
        }

        private void Seed()
        {
            this.addresses.Enqueue("https://softuni.bg/");
            this.addresses.Enqueue("http://stackoverflow.com/");
            this.addresses.Enqueue("https://www.youtube.com/");
            this.addresses.Enqueue("https://www.google.bg/");
        }
    }
}
