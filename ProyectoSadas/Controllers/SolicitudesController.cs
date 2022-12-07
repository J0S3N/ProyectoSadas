using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoSadas.Data;
using ProyectoSadas.Models;

namespace ProyectoSadas.Controllers
{
    public class SolicitudesController : Controller
    {
        private readonly ProyectoSadasContexto _context;

        public SolicitudesController(ProyectoSadasContexto context)
        {
            _context = context;
        }

        // GET: Solicitudes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Solicitud.ToListAsync());
        }

        // GET: Solicitudes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Solicitud == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return View(solicitud);
        }

        // GET: Solicitudes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solicitudes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaRealiza,NombrePersonaSolicitante,PuestoDesenpenna,OtroAnote,NumeroTelefono,SedeRecibe,NombrePersonaRecibe,MetodoEnvio,DocumentoIdentidadPersonaEstudiante,NombrePersonaEstudiante,FechaNacimientoEstudiante,EdadEstudiante,NivelEducativoEstudiante,ServicioEducativoPerteneceEstudiante,DescripcionCondicionPresentaEstudiante,NombreMadreEstudiante,NombrePadreEstudiante,OtraPersonaResponsableEstudiante,CorreoElectronicoEstudiante,NumeroTelefonoEstudiante,ProvinciaEstudiante,CantonEstudiante,DistritoEstudiante,DireccionEstudiante,NombreCentroEducativo,NumeroTelefonoCentroEducativo,OtroNumeroTelefonoCentroEducativo,CorreoElectronicoCentroEducativo,ProvinciaCentroEducativo,CantonCentroEducativo,DistritoCentroEducativo,DireccionCentroEducativo,RegionEducativaCentroEducativo,CircuitoCentroEducativo,PersonaDocenteCentroEducativo,CorreoPersonaDocenteCentroEducativo,NombrePersonaCentroEducativo,MotivoSolicitud,ApoyoOrganizatiVoSolicitud,ProductoApoyoEmpleadoSolicitud,ServicioApoyoRecibe,ServicioApoyoRecibeRegionEducativa,ApoyoEducativoRequeridoComunicacion,ApoyoEducativoRequeridoComunicacionDescripcion,ApoyoEducativoRequeridoAutocuidado,ApoyoEducativoRequeridoAutocuidadoDescripcion,ApoyoEducativoRequeridoAcademica,ApoyoEducativoRequeridoAcademicaDescripcion,ApoyoEducativoRequeridoMotriz,ApoyoEducativoRequeridoMotrizDescripcion,ApoyoEducativoRequeridoVisual,ApoyoEducativoRequeridoVisualDescripcion,ApoyoEducativoRequeridoUtilizacionComunidad,ApoyoEducativoRequeridoUtilizacionComunidadDescripcion,ApoyoEducativoRequeridoFormacionTrabajo,ApoyoEducativoRequeridoFormacionTrabajoDescripcion,ApoyoEducativoRequeridoOtros,ApoyoEducativoRequeridoOtrosDescripcion,AsesoriaPrevia,SedeAsesoriaPrevia,AdjuntaCertificacionMedicaCCSS,AdjuntaCertificacionMedicaCONAPDIS,ProductoApoyoGubernamental,ProductoApoyoGubernamentalDescripcion,ProductoApoyoNoGubernamental,ProductoApoyoNoGubernamentalDescripcion")] Solicitud solicitud)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitud);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitud);
        }

        // GET: Solicitudes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Solicitud == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud.FindAsync(id);
            if (solicitud == null)
            {
                return NotFound();
            }
            return View(solicitud);
        }

        // POST: Solicitudes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaRealiza,NombrePersonaSolicitante,PuestoDesenpenna,OtroAnote,NumeroTelefono,SedeRecibe,NombrePersonaRecibe,MetodoEnvio,DocumentoIdentidadPersonaEstudiante,NombrePersonaEstudiante,FechaNacimientoEstudiante,EdadEstudiante,NivelEducativoEstudiante,ServicioEducativoPerteneceEstudiante,DescripcionCondicionPresentaEstudiante,NombreMadreEstudiante,NombrePadreEstudiante,OtraPersonaResponsableEstudiante,CorreoElectronicoEstudiante,NumeroTelefonoEstudiante,ProvinciaEstudiante,CantonEstudiante,DistritoEstudiante,DireccionEstudiante,NombreCentroEducativo,NumeroTelefonoCentroEducativo,OtroNumeroTelefonoCentroEducativo,CorreoElectronicoCentroEducativo,ProvinciaCentroEducativo,CantonCentroEducativo,DistritoCentroEducativo,DireccionCentroEducativo,RegionEducativaCentroEducativo,CircuitoCentroEducativo,PersonaDocenteCentroEducativo,CorreoPersonaDocenteCentroEducativo,NombrePersonaCentroEducativo,MotivoSolicitud,ApoyoOrganizatiVoSolicitud,ProductoApoyoEmpleadoSolicitud,ServicioApoyoRecibe,ServicioApoyoRecibeRegionEducativa,ApoyoEducativoRequeridoComunicacion,ApoyoEducativoRequeridoComunicacionDescripcion,ApoyoEducativoRequeridoAutocuidado,ApoyoEducativoRequeridoAutocuidadoDescripcion,ApoyoEducativoRequeridoAcademica,ApoyoEducativoRequeridoAcademicaDescripcion,ApoyoEducativoRequeridoMotriz,ApoyoEducativoRequeridoMotrizDescripcion,ApoyoEducativoRequeridoVisual,ApoyoEducativoRequeridoVisualDescripcion,ApoyoEducativoRequeridoUtilizacionComunidad,ApoyoEducativoRequeridoUtilizacionComunidadDescripcion,ApoyoEducativoRequeridoFormacionTrabajo,ApoyoEducativoRequeridoFormacionTrabajoDescripcion,ApoyoEducativoRequeridoOtros,ApoyoEducativoRequeridoOtrosDescripcion,AsesoriaPrevia,SedeAsesoriaPrevia,AdjuntaCertificacionMedicaCCSS,AdjuntaCertificacionMedicaCONAPDIS,ProductoApoyoGubernamental,ProductoApoyoGubernamentalDescripcion,ProductoApoyoNoGubernamental,ProductoApoyoNoGubernamentalDescripcion")] Solicitud solicitud)
        {
            if (id != solicitud.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitud);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudExists(solicitud.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(solicitud);
        }

        // GET: Solicitudes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Solicitud == null)
            {
                return NotFound();
            }

            var solicitud = await _context.Solicitud
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitud == null)
            {
                return NotFound();
            }

            return View(solicitud);
        }

        // POST: Solicitudes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Solicitud == null)
            {
                return Problem("Entity set 'ProyectoSadasContexto.Solicitud'  is null.");
            }
            var solicitud = await _context.Solicitud.FindAsync(id);
            if (solicitud != null)
            {
                _context.Solicitud.Remove(solicitud);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitudExists(int id)
        {
            return _context.Solicitud.Any(e => e.Id == id);
        }
    }
}
