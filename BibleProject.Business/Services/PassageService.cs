using System.Collections.Generic;
using System.Linq;
using BibleProject.Repository;
using BibleProject.Repository.Repositories;

namespace BibleProject.Business.Services
{
    public class PassageService
    {
        public IEnumerable<PassageViewModel> GetPassages()
        {
            var passages = new PassageRepository().GetPassages();
            
            return passages.Result.Select(passage => new PassageViewModel
            {
                Passages = passage.Passages
            });
        }
    }
}