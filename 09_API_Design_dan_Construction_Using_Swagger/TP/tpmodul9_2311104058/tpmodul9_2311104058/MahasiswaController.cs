using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul9_2311104058;

namespace MahasiswaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Dimastian Aji Wibowo", "2311104058"),
            new Mahasiswa("Zhafir Zaidan Avail", "2311104059"),
            new Mahasiswa("Alvin Bagus Firmansyah", "2311104070")
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak valid");

            return mahasiswaList[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mahasiswaBaru)
        {
            mahasiswaList.Add(mahasiswaBaru);
            return Ok("Mahasiswa ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak valid");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa dihapus");
        }
    }
}
