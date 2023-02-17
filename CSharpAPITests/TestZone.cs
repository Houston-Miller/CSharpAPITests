using FluentAssertions;
using Xunit.Abstractions;
using FluentAssertions.Execution;
namespace CSharpAPITests
{
    public class TestZone
    {
        [Fact]
        // In-Class example of steam players online/players in game stats, GET
        public async Task AreThereGamersTest()
        {
            string url = "https://www.valvesoftware.com/about/stats";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.valvesoftware.com");

            var result = await client.GetAsync("/about/stats");
            var content = await result.Content.ReadAsStringAsync();

            var stats = System.Text.Json.JsonSerializer.Deserialize<SteamStatsResponse>(content);

            using (new AssertionScope())
            {
                int.Parse(stats.users_online, System.Globalization.NumberStyles.AllowThousands)
                    .Should().BeGreaterOrEqualTo(int.Parse(stats.users_ingame, System.Globalization.NumberStyles.AllowThousands));

                result.IsSuccessStatusCode.Should().BeTrue();
            }
        }

        [Fact]
        //Overwatch player stats API pulling a streamer's data - GET
        public async Task AreYaWinninSonTest()
        {
            string url = "https://overfast-api.tekrop.fr/players/emongg-11183/stats";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://overfast-api.tekrop.fr");

            var result = await client.GetAsync("players/emongg-11183/stats/summary");
            var content = await result.Content.ReadAsStringAsync();

            var PlayerSummary = System.Text.Json.JsonSerializer.Deserialize<OverfastResponseSummary>(content);

            using (new AssertionScope())
            {
                result.IsSuccessStatusCode.Should().BeTrue();
                PlayerSummary.roles.tank.winrate.Should().BeGreaterOrEqualTo(50);
            }

        }


        [Fact]
        //Overwatch player stats API pulling my data, as I am no longer a coward, asserting deeper into the response tree - GET
        //If this failes please note that I must have had a string of bad games and it's not my fault okay
        public async Task GenjiMainBTWTest()
        {
            string url = "https://overfast-api.tekrop.fr/players/emongg-11183/stats";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://overfast-api.tekrop.fr");

            var result = await client.GetAsync("players/Moxie-11981/stats/summary");
            var content = await result.Content.ReadAsStringAsync();

            var PlayerSummary = System.Text.Json.JsonSerializer.Deserialize<OverfastResponseSummary>(content);

            using (new AssertionScope())
            {
                result.IsSuccessStatusCode.Should().BeTrue();
                PlayerSummary.heroes.genji.winrate.Should().BeGreaterOrEqualTo(50);
                PlayerSummary.heroes.genji.average.eliminations.Should().BeGreaterOrEqualTo(20);
            }

        }

        [Fact]
        //Overwatch hero information, sending a query that does not match the database - Negative Test
        public async Task HeroDataTestNegative()
        {
            string url = "https://overfast-api.tekrop.fr/players/emongg-11183/stats";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://overfast-api.tekrop.fr");

            var result = await client.GetAsync("heroes/Wraith");
            var content = await result.Content.ReadAsStringAsync();

            var HeroData = System.Text.Json.JsonSerializer.Deserialize<OverFastCharacterResponse>(content);

            using (new AssertionScope())
            {
                result.IsSuccessStatusCode.Should().BeFalse();
                result.ReasonPhrase.Should().Be("Unprocessable Entity");
            }

        }

        [Fact]
        // In-Class example of posting to a Test API - POST
        public async Task POSTTest()
        {
            HttpClient client = new()
            {
                BaseAddress = new("https://reqres.in/")
            };
            RegisterPostModel postBody = new RegisterPostModel()
            {
                Username = "eve.holt@reqres.in",
                Email = "eve.holt@reqres.in",
                Password = "pistol"
            };
            var serialized = System.Text.Json.JsonSerializer.Serialize(postBody);
            var reult = await client.PostAsync("/api/register",
                new StringContent(serialized, encoding: System.Text.Encoding.UTF8));
        }

        [Fact]
        //"Removing" that posted user from the revious example on the Test API - DELETE
        public async Task DELETETest()
        {
            HttpClient client = new()
            {
                BaseAddress = new("https://reqres.in/")
            };

            var result = await client.DeleteAsync("api/user/2");
            var content = await result.Content.ReadAsStringAsync();



            content.Should().BeNullOrEmpty();

        }
    }
}