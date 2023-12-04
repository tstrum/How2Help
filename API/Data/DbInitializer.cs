using System.Net.Http.Headers;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Organizations.Any()) return;

            var organizations = new List<Organization>
            {
                new Organization
                {
                    Name="Brady",
                    Description="There is no one solution to end this epidemic of gun violence. So our comprehensive approach addresses every aspect with more than 45 years of research and real-world experience. Let’s put the Brady plan into action now and get the job done right.",
                    Url="https://www.bradyunited.org/",
                    ImageUrl="/images/products/sb-ang1.png",
                    Category="Gun Violence"
                },
                new Organization
                {
                    Name="Emilys List",
                    Description="We recruit, train, and support Democratic pro-choice women running for office up and down the ballot. Because in office, these women can change the world.",
                    Url="https://emilyslist.org/",
                    ImageUrl="/images/products/sb-ang2.png",
                    Category="Abortion Rights"
                },
                new Organization
                {
                    Name="RunForSomething",
                    Description="We recruit and support young progressives.",
                    Url="https://runforsomething.net/",
                    ImageUrl="/images/products/sb-core2.png",
                    Category="Minority representation"
                },
                new Organization
                {
                    Name="US Campaign for Palestinian Rights",
                    Description="As part of a global movement for collective liberation, we work to end U.S. complicity in Israel's massive violence against the Palestinian people.",
                    Url="https://uscpr.org/",
                    ImageUrl="/images/products/sb-core1.png",
                    Category="Palestinian Rights"
                },
                new Organization
                {
                    Name="Doctors Without Borders",
                    Description="Every day, Doctors Without Borders teams deliver emergency medical aid to people in crisis, with humanitarian projects in more than 70 countries.",
                    Url="https://www.doctorswithoutborders.org/",
                    ImageUrl="/images/products/sb-react1.png",
                    Category="Humanitarian Medical Care"
                },
            };

            context.Organizations.AddRange(organizations);
            context.SaveChanges();
        }
    }
}