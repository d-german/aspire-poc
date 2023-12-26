var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireAppPoc_ApiService>("apiservice");

builder.AddProject<Projects.AspireAppPoc_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();