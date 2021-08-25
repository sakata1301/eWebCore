using eWebCore.Application.Catalog.ProductFolder;
using eWebCore.ViewModels.Catalog.Product;
using eWebCore.ViewModels.Catalog.ProductImage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWebCore.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAll(string languageId)
        {
            var data = await _publicProductService.GetAll(languageId);
            return Ok(data);
        }

        [HttpGet("/{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _manageProductService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("Can not find product");

            return Ok(product);
        }

        [HttpGet("/public-paging/{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var data = await _publicProductService.GetProductByCategory(languageId, request);
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateReq request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }

            var product = await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateReq request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.Update(request);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var result = await _manageProductService.Delete(productId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("/price/{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _manageProductService.UpdatePrice(productId, newPrice);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("/{productId}/image/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _manageProductService.GetImageById(productId, imageId);
            if (image == null)
                return BadRequest("Can not find product");

            return Ok(image);
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreatedImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.AddImage(productId, request);
            if (result == 0)
            {
                return BadRequest();
            }

            var product = await _manageProductService.GetImageById(productId, result);
            return CreatedAtAction(nameof(GetImageById), new { id = productId }, product);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int productId, int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.UpdateImage(productId, imageId, request);
            if (result == 0)
            {
                return BadRequest();
            }

            var product = await _manageProductService.GetImageById(productId, result);
            return CreatedAtAction(nameof(GetImageById), new { id = productId }, product);
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int productId, int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.RemoveImage(productId, imageId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}