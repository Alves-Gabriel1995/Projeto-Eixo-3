var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/trocasenha/{usuario}/{senha}", async context =>
{
    var usuario = context.Request.RouteValues["usuario"];
    var senha = context.Request.RouteValues["senha"];

    System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
    process.UseShellExecute = false;
    process.WorkingDirectory = "/bin";
    process.FileName = "sh";
    process.Arguments = $"/home/vboxuser/Desktop/trocasenha.sh {usuario} {senha}";
    process.RedirectStandardOutput = true;

    System.Diagnostics.Process cmd = System.Diagnostics.Process.Start(process);
    // waiting to complete 
    cmd.WaitForExit();

    await context.Response.WriteAsync("Processo executado");
});

app.Run();
