﻿Part part = new(Guid.NewGuid(), "Transistor BC547", new StockKeepingUnit("ELTRBC547"));

Part another = part with { Name = "BC547" };

AssemblySpecification spec = new(Guid.NewGuid(), "Traffic light", "DIY project");

AssemblySpecification next = new(spec)
{
    Name = "Traffic signals"
};