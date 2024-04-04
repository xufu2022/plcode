﻿using System.Text;

namespace DataProcessing.Reporting;

internal class InsecureHostsReportWriter : DataWriter<InsecureHostsByIPAddressDictionary>
{
    private const int LineSeparatorLength = 30;

    public InsecureHostsReportWriter(ProcessingOptions options) : base(options)
    {
    }

    protected override async Task WriteAsyncCore(
        string pathAndFileName, 
        InsecureHostsByIPAddressDictionary data, 
        CancellationToken cancellationToken = default)
    {
        var sb = new StringBuilder();

        foreach (var (ip, hostnames) in data)
        {
            var ipString = ip.ToString();

            sb.AppendLine(ipString);
            sb.Append('-', ipString.Length).AppendLine();

            foreach (var hostname in hostnames)
            {
                sb.AppendLine(hostname);
            }

            sb.AppendLine().Append('*', LineSeparatorLength).AppendLine().AppendLine();
        }

        var lengthToRemove = (Environment.NewLine.Length * 3) + LineSeparatorLength;
        sb.Remove(sb.Length - lengthToRemove, lengthToRemove);

        foreach (var writer in OutputWriters)
        {
            await writer.WriteDataAsync(sb.ToString(), pathAndFileName, cancellationToken);
        }
    }
}
