using Projects;
using TUnit.Aspire;

namespace UnitTests.TestProject
{
  public class AppFixture : AspireFixture<Portfolio_AppHost>
  {
    protected override void ConfigureBuilder(IDistributedApplicationTestingBuilder builder)
    {
      builder.Services.ConfigureHttpClientDefaults(clientBuilder =>
      {
        clientBuilder.AddStandardResilienceHandler();
      });
    }
  }
}
