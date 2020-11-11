using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DotNetNote.Controllers
{
    public class FileDemoController : Controller
    {
        [Obsolete]
        private IHostingEnvironment _environment;

        [Obsolete]
        public FileDemoController(IHostingEnvironment environment)
        {
            this._environment = environment;
        }

        /// <summary>
        /// 파일 업로드 폼 
        /// </summary>
        [HttpGet]
        public IActionResult FileUploadDemo()
        {
            return View();
        }

        /// <summary>
        /// 파일 업로드 처리
        /// 보안상 파일 업로드 처리 코드는 주석 처리합니다.
        /// </summary>
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> FileUploadDemo(
            ICollection<IFormFile> files)
        {
            var uploadFolder = Path.Combine(_environment.WebRootPath, "files");
            DirectoryInfo dir = new DirectoryInfo(uploadFolder);
            if (!dir.Exists)
            {
                dir.Create();
            }
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    using (var fileStream = new FileStream(
                        Path.Combine(uploadFolder, fileName.ToString()), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
            }

            return View();
        }

        /// <summary>
        /// 파일 다운로드 처리 데모
        /// </summary>
        [Obsolete]
        public FileResult FileDownloadDemo(string fileName = "Test.txt")
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(
                Path.Combine(
                    _environment.WebRootPath, "files") + "\\" + fileName);

            return File(fileBytes, "application/octet-stream", fileName);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
