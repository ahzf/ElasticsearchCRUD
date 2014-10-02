﻿using System;
using System.Diagnostics;

namespace ElasticsearchCRUD.Tracing
{
	public interface ITraceProvider
	{
		void Trace(TraceLevel level, string message, params object[] args);
		void Trace(TraceLevel level, Exception ex, string message, params object[] args);
	}
}
