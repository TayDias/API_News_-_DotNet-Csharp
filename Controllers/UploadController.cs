using ImageProcessor;
using ImageProcessor.Plugins.WebP.Imaging.Formats;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController: ControllerBase
    {
        private readonly ILogger<UploadController> _logger;

        public UploadController(ILogger<UploadController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post(IFormFile image)
        {
            try
            {
                //validação simples, caso não tenha sido enviado nenhuma imagem para upload nós estamos retornando null
                if (image == null) return null;

                var nameImage = image.FileName;

                //Salvando a imagem no formato enviado pelo usuário
                using (var stream = new FileStream(Path.Combine("Imagens", nameImage), FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                var webpNameImage = Guid.NewGuid() + ".webp";

                // Salvando no formato WebP
                using (var webPFileStream = new FileStream(Path.Combine("Imagens", webpNameImage), FileMode.Create))
                {
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: false))
                    {
                        imageFactory.Load(image.OpenReadStream()) //carregando os dados da imagem
                                    .Format(new WebPFormat()) //formato
                                    .Quality(100) //parametro para não perder a qualidade no momento da compressão
                                    .Save(webPFileStream); //salvando a imagem
                    }
                }

                // Falha causada por limitação de pacote ao ambiente Windows
                //https://stackoverflow.com/questions/67091719/system-drawing-common-the-type-initializer-for-gdip-threw-an-exception


                return Ok(new
                {
                    mensagem = "Imagem salva com sucesso!",
                    urlImagem = $"http://localhost:5130/imgs/{webpNameImage}"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro no upload: " + ex.Message);
            }

        }
    }
}