using MinimalApi;

IHostBuilder CreateHostBuilder(string[] argrs) //criamos um Host, e delegamos os itens para a StartUp
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder => 
        {
            webBuilder.UseStartup<StartupBase>();
        });
}

CreateHostBuilder(args).Build().Run();