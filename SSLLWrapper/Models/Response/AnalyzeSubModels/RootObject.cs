﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLLWrapper.Models.Response.AnalyzeSubModels
{
	public class RootObject
	{
		public string host { get; set; }
		public int port { get; set; }
		public string protocol { get; set; }
		public bool isPublic { get; set; }
		public string status { get; set; }
		public long startTime { get; set; }
		public string engineVersion { get; set; }
		public string criteriaVersion { get; set; }
		public List<Endpoint> endpoints { get; set; }
	}
}
