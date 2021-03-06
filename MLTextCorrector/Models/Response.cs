﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLTextCorrector.Models
{
    public class Response
    {
        public string _type { get; set; }
        public List<FlaggedToken> flaggedTokens { get; set; }

        public class Suggestion
        {
            public string suggestion { get; set; }
            public double score { get; set; }
        }

        public class FlaggedToken
        {
            public int offset { get; set; }
            public string token { get; set; }
            public string type { get; set; }
            public List<Suggestion> suggestions { get; set; }
        }
        
    }
}