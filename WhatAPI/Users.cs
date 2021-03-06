﻿using System.Collections.Generic;

namespace What
{
    public class Users
    {
        public string status { get; set; }
        public Response response { get; set; }

        public override string ToString()
        {
            return status;
        }

        public class Response
        {
            public uint currentPage { get; set; }
            public uint pages { get; set; }
            public List<Result> results { get; set; }

            public override string ToString()
            {
                return string.Format("Page {0} of {1}", currentPage, pages);
            }
        }

        public class Result
        {
            public uint userId { get; set; }
            public string username { get; set; }
            public bool donor { get; set; }
            public bool warned { get; set; }
            public bool enabled { get; set; }
            public string @class { get; set; }

            public override string ToString()
            {
                return username;
            }
        }
    }
}