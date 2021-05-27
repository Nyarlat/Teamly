using RARI.PageModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RARI.Services
{
    public interface INavigationService
    {
        /// <summary>
        /// Метод навигации для вставки в стек навигации
        /// </summary>
        /// <typeparam name="TPageModel"></typeparam>
        /// <param name="navigationData"></param>
        /// <param name="setRoot"></param>
        /// <returns></returns>
        Task NavigateToAsync<TPageModel>(object navigationData = null, bool setRoot = false)
            where TPageModel : PageModelBase;

        /// <summary>
        /// Метод навигации для извлечения из стека навигации
        /// </summary>
        /// <returns></returns>
        Task GoBackAsync();
    }
}
