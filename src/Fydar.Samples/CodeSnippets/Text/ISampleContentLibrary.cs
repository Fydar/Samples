﻿using System.Collections.Generic;
using System.Threading;

namespace Fydar.Samples.CodeSnippets.Text;

public interface ISampleContentLibrary
{
	IAsyncEnumerable<SampleContent> FindSampleContentsAsync(
		CancellationToken cancellationToken = default);
}