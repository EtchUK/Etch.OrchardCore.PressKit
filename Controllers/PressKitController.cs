using Etch.OrchardCore.Blocks.Models;
using Etch.OrchardCore.Blocks.Parsers;
using Etch.OrchardCore.PressKit.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Etch.OrchardCore.PressKit.Controllers
{
    public class PressKitController : Controller
    {
        #region Dependencies

        private readonly IBlocksParser _blocksParser;
        private readonly IContentManager _contentManager;

        #endregion

        #region Constructor

        public PressKitController(IBlocksParser blocksParser, IContentManager contentManager)
        {
            _blocksParser = blocksParser;
            _contentManager = contentManager;
        }

        #endregion

        [HttpGet]
        [Route("/press-kit/{id}")]
        public async Task<IActionResult> Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            var contentItem = await _contentManager.GetAsync(id);

            if (contentItem == null)
            {
                return NotFound();
            }

            var model = new PressKitViewModel(contentItem);
            model.Description = await GetBlocksAsync(contentItem, "Description");
            model.History = await GetBlocksAsync(contentItem, "History");

            return View(model);
        }

        private async Task<IList<dynamic>> GetBlocksAsync(ContentItem contentItem, string partName)
        {
            return await _blocksParser.RenderAsync(contentItem.Get<BlockBodyPart>(partName));
        }
    }
}
