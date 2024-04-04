using System.Globalization;

using DataProcessing.Reporting;

using Microsoft.Extensions.Logging.Abstractions;

namespace DataProcessing.Benchmarks;

public class SalesDataWriterBenchmarks
{
    private SalesDataWriter? _salesDataWriter = null;
    private StringBuilderSalesDataWriter? _salesDataWriterV2 = null;
    private IEnumerable<HistoricalSalesData>? _salesData = null;

    [Params(1, 100)]
    public int Size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var options = new ProcessingOptions(new CultureInfo("en-GB"), new SessionContext("Test", "User", "1000"), new NullLoggerFactory())
            .AddOutputWriter(new NoOpOutputWriter());

        _salesDataWriter = new SalesDataWriter(options);
        _salesDataWriterV2 = new StringBuilderSalesDataWriter(options);

        var data = new List<HistoricalSalesData>();

        for (int i = 0; i < Size; i++)
        {
            data.Add(new HistoricalSalesData
            {
                ProductName = "Test Product",
                ProductInfo = ProductInfo.Parse("764896:AB65"),
                Quantity = 100,
                UnitPrice = 15.6m,
                SalesTaxPercentage = 10,
                Category = new Category("ENG001", "Engineering (Mechanical)"),
                UtcSalesDateTime = new DateTimeOffset(2022, 01, 01, 15, 00, 00, TimeSpan.Zero),
                CurrencySymbol = "£",
            });
        }

        _salesData = data;
    }

    public string? Output { get; private set; }

    [Benchmark]
    public async Task WithoutStringBuilder()
    {
        await _salesDataWriter!.WriteAsync("test.txt", _salesData!);
    }

    [Benchmark]
    public async Task WithStringBuilder()
    {
        await _salesDataWriterV2!.WriteAsync("test.txt", _salesData!);
    }

    private class NoOpOutputWriter : IOutputWriter
    {
        public Task WriteDataAsync(string data, string pathandFileName, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
    }
}
