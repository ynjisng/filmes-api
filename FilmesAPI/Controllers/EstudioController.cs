using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Estudio;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudioController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EstudioController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Estudio> RecuperarEstudio() => _context.Estudios;

        [HttpPost]
        public IActionResult AdicionarEstudio([FromBody] CreateEstudioDto estudioDto)
        {
            Estudio estudio = _mapper.Map<Estudio>(estudioDto);

            _context.Estudios.Add(estudio);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarEstudioPorId), new { Id = estudio.Id }, estudio);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarEstudioPorId(int id)
        {
            Estudio estudio = _context.Estudios.FirstOrDefault(filme => filme.Id == id);
            if (estudio != null)
            {
                ReadEstudioDto filmeDto = _mapper.Map<ReadEstudioDto>(estudio);

                return Ok(filmeDto);
            }
            return NotFound();

        }

        [HttpPut("{id}")]
        public IActionResult AtualizarEstudio(int id, [FromBody] UpdateEstudioDto filmeDto)
        {
            Estudio estudio = _context.Estudios.FirstOrDefault(filme => filme.Id == id);
            if (estudio == null)
            {
                return NotFound();
            }

            _mapper.Map(filmeDto, estudio);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarEstudio(int id)
        {
            Estudio estudio = _context.Estudios.FirstOrDefault(estudio => estudio.Id == id);
            if (estudio == null)
            {
                return NotFound();
            }

            _context.Remove(estudio);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
