using System.Threading.Tasks;
using News.Models;
using News.Services;


namespace News.ViewModels
{
    public class PlanetsViewModel: ViewModel
    {
        private readonly StarWarsService starWarsService;

        public StarWarsResult CurrentPlanets { get; set; }

        public PlanetsViewModel(StarWarsService starWarsService)
        {
            this.starWarsService = starWarsService;
        }

        public async Task Initialize()
        {
            CurrentPlanets = await starWarsService.GetPlanets();    
        }
    }
}
