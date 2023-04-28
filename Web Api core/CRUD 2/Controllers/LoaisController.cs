using CRUD_2.Data;
using CRUD_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private MyDbContext _context;



        public LoaisController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _context.Loais.ToList();
            return Ok(dsLoai);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var dsLoai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
            if (dsLoai != null)
            {
                return Ok(dsLoai);

            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult CreateNew(LoaiModel model)
        {
            try
            {
                var loai = new Loai
                {
                    TenLoai = model.TenLoai,

                };

                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch {
                return BadRequest();
            }

            }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id,LoaiModel model)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.MaLoai == id);
            if (loai != null)
            {
                loai.TenLoai=model.TenLoai;
                _context.SaveChanges();
                return NoContent();

            }
            else
            {
                return NotFound();
            }
        }
    }
}

