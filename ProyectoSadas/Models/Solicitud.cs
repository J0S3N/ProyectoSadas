using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace ProyectoSadas.Models
{
    public class Solicitud
    {
        /*#------------------------------------------------------------------------------------------------------------------------------------#*/
        /*| Identificadores de la Tabla                                                                                                         */
        /*#------------------------------------------------------------------------------------------------------------------------------------#*/
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Numero")]
        public int Id { get; set; }

        /*#------------------------------------------------------------------------------------------------------------------------------------#*/
        /*| Informacion de la Tabla                                                                                                             */
        /*#------------------------------------------------------------------------------------------------------------------------------------#*/

        //  I. Información de la solicitud

        [Required(ErrorMessage = "La fecha en que se realiza la solicitud es obligatorio")]
        [DisplayName("Fecha en  la que se realiza la solicitud")]
        public DateTime? FechaRealiza { get; set; }

        [Required(ErrorMessage = "El nombre de la persona solicitante es obligatorio")]
        [DisplayName("Nombre de la persona solicitante")]
        public String? NombrePersonaSolicitante { get; set; }

        [Required(ErrorMessage = "El puesto que desempeña es obligatorio")]
        [DisplayName("Puesto que desempeña")]
        public String? PuestoDesenpenna { get; set; }

        [Required(ErrorMessage = "Otro anote es obligatorio")]
        [DisplayName("Otro anote")]
        public String? OtroAnote { get; set; }

        [Required(ErrorMessage = "El número de Teléfono es obligatorio")]
        [DisplayName("Numero de teléfono")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Por favor, escriba un número de teléfono válido")]
        public string? NumeroTelefono { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [DisplayName("Correo electrónico")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "El correo electrónico no es aceptado")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "La fecga en que se recibe la solicitud es obligatorio")]
        [DisplayName("Fecha en la que se recibe la solicitud")]
        public DateTime? FechaRecibe { get; set; }

        [Required(ErrorMessage = "La sede donde se recibe la solicitud es obligatorio")]
        [DisplayName("Sede")]
        public string? SedeRecibe { get; set; }
        
        [Required(ErrorMessage = "El nombre de la persona que recibe la solicitud es obligatorio")]
        [DisplayName("Nombre de la persona que recibe la solicitud")]
        public string? NombrePersonaRecibe { get; set; }

        [Required(ErrorMessage = "El método de envío de la solicitud es obligatorio")]
        [DisplayName("Método de envío")]
        public string? MetodoEnvio { get; set; }

        // II. Información de la persona estudiante que requiere la asesoría

        [Required(ErrorMessage = "El tipo de documento de identidad del estudiante es obligatorio")]
        [DisplayName("Tipo de documento de identidad de la persona estudiante")]
        public String? TipoDocumentoIdentidadPersonaEstudiante { get; set; }


        [Required(ErrorMessage = "El documento de identidad del estudiante es obligatorio")]
        [RegularExpression(@"^[A-Z0-9]+$", ErrorMessage = "Por favor, escriba un documento de identidad válido")]
        [DisplayName("Documento de identidad")]
        public String? DocumentoIdentidadPersonaEstudiante { get; set; }

        [Required(ErrorMessage = "El nombre de la persona estudiante es obligatorio")]
        [DisplayName("Nombre")]
        public String? NombrePersonaEstudiante { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento del estudiante es obligatorio")]
        [DisplayName("Fecha de nacimiento")]
        public DateTime? FechaNacimientoEstudiante { get; set; }

        [Required(ErrorMessage = "La edad del estudiante es obligatorio")]
        [DisplayName("Edad")]
        public string? EdadEstudiante { get; set; }
        
        [Required(ErrorMessage = "El nivel educativo que cursa el estudiante es obligatorio")]
        [DisplayName("Nivel educativo")]
        public String? NivelEducativoEstudiante { get; set; }

        [Required(ErrorMessage = "El servicio educativo al que pertenece el estudiante es obligatorio")]
        [DisplayName("Servicio educativo al que pertenece")]
        public String? ServicioEducativoPerteneceEstudiante { get; set; }

        [Required(ErrorMessage = "La descripción de la condición que presenta la persona estudiante es obligatorio")]
        [DisplayName("Descripción de la condición que presenta la persona")]
        public String? DescripcionCondicionPresentaEstudiante { get; set; }

        [Required(ErrorMessage = "El nombre de la madre la persona estudiante es obligatorio")]
        [DisplayName("Nombre de la madre")]
        public String? NombreMadreEstudiante { get; set; }

        [Required(ErrorMessage = "El nombre del padre la persona estudiante es obligatorio")]
        [DisplayName("Nombre del padre")]
        public String? NombrePadreEstudiante { get; set; }

        [DisplayName("Otra persona responsable")]
        public String? OtraPersonaResponsableEstudiante { get; set; } = "No aplica";

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "El correo electrónico no es aceptado")]
        [DisplayName("Correo electrónico")]
        public String? CorreoElectronicoEstudiante { get; set; }

        [Required(ErrorMessage = "El número de teléfono de contacto de la persona estudiante es obligatorio")]
        [DisplayName("Numero de teléfono")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Por favor, escriba un número de teléfono válido")]
        public string? NumeroTelefonoEstudiante { get; set; }
        
        [Required(ErrorMessage = "La provincia de residencia de la persona estudiante es obligatorio")]
        [DisplayName("Provincia")]
        public string? ProvinciaEstudiante { get; set; }

        [Required(ErrorMessage = "El cantón de residencia de la persona estudiante es obligatorio")]
        [DisplayName("Cantón")]
        public string? CantonEstudiante { get; set; }
        
        [Required(ErrorMessage = "El distrito de residencia de la persona estudiante es obligatorio")]
        [DisplayName("Distrito")]
        public string? DistritoEstudiante { get; set; }

        [Required(ErrorMessage = "La dirección de residencia de la persona estudiante es obligatorio")]
        [DisplayName("Dirección")]
        public string? DireccionEstudiante { get; set; }

        // III. Información del centro educativo al que asiste la persona estudiante

        [Required(ErrorMessage = "El nombre del centro educativo de la persona estudiante es obligatorio")]
        [DisplayName("Nombre")]
        public string? NombreCentroEducativo { get; set; }

        [Required(ErrorMessage = "El número de teléfono del centro educativo es obligatorio")]
        [DisplayName("Número de teléfono")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Por favor, escriba un número de teléfono válido")]
        public string? NumeroTelefonoCentroEducativo { get; set; }

        [DisplayName("Otro número de teléfono")]
        [RegularExpression(@"^([0-9]{8})$", ErrorMessage = "Por favor, escriba un número de teléfono válido")]
        public string? OtroNumeroTelefonoCentroEducativo { get; set; } = "No aplica";

        [Required(ErrorMessage = "El correo electrónico del centro esudcativo es obligatorio")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "El correo electrónico no es aceptado")]
        [DisplayName("Correo electrónico")]
        public String? CorreoElectronicoCentroEducativo { get; set; }

        [Required(ErrorMessage = "La provincia del centro educativo es obligatorio")]
        [DisplayName("Provincia")]
        public string? ProvinciaCentroEducativo { get; set; }

        [Required(ErrorMessage = "El cantón del centro educativo es obligatorio")]
        [DisplayName("Cantón")]
        public string? CantonCentroEducativo { get; set; }

        [Required(ErrorMessage = "El distrito del centro educativo es obligatorio")]
        [DisplayName("Distrito")]
        public string? DistritoCentroEducativo { get; set; }
        
        [Required(ErrorMessage = "La dirección del centro educativo es obligatorio")]
        [DisplayName("Dirección")]
        public string? DireccionCentroEducativo { get; set; }

        [Required(ErrorMessage = "La región educativa del centro educativo es obligatorio")]
        [DisplayName("Región educativa")]
        public string? RegionEducativaCentroEducativo { get; set; }
        
        [Required(ErrorMessage = "El circuito del centro educativo es obligatorio")]
        [DisplayName("Circuito")]
        public string? CircuitoCentroEducativo { get; set; }

        [Required(ErrorMessage = "El nombre de la persona docente a cargo es obligatorio")]
        [DisplayName("Nombre de la persona docente a cargo")]
        public string? PersonaDocenteCentroEducativo { get; set; }

        [Required(ErrorMessage = "El correo electrónico de la persona docenteo es obligatorio")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "El correo electrónico no es aceptado")]
        [DisplayName("Correo electrónico de la persona docente")]
        public String? CorreoPersonaDocenteCentroEducativo { get; set; }

        [Required(ErrorMessage = "El nombre de la persona a cargo de la Dirección es obligatorio")]
        [DisplayName("Nombre de la persona a cargo de la Dirección")]
        public string? NombrePersonaCentroEducativo { get; set; }

        // IV. Información sobre la solicitud de asesoría

        [Required(ErrorMessage = "El motivo de la solicitud es obligatorio")]
        [DisplayName("Motivo de la solicitud")]
        public string? MotivoSolicitud { get; set; }

        [Required(ErrorMessage = "Los apoyos organizativos son obligatorios")]
        [DisplayName("Apoyos organizativos (de acceso) aplicadas en el trabajo con la persona estudiante")]
        public string? ApoyoOrganizatiVoSolicitud { get; set; }

        [Required(ErrorMessage = "Los productos de apoyo que ha empleado son obligatorios")]
        [DisplayName("Productos de apoyo que ha empleado o emplea la persona estudiante")]
        public string? ProductoApoyoEmpleadoSolicitud { get; set; }

        [Required(ErrorMessage = "Los servicios de apoyo que recibe la persona estudiante en la región de asesoría es obligatorio")]
        [DisplayName("Servicios de apoyo que recibe la persona estudiante en la región:")]
        public string? ServicioApoyoRecibe { get; set; }

        [Required(ErrorMessage = "Los servicios de apoyo con los que cuenta la región educativa de asesoría es obligatorio")]
        [DisplayName("Servicios de apoyo con los que cuenta la región educativa")]
        public string? ServicioApoyoRecibeRegionEducativa { get; set; }

        public int? ApoyoEducativoRequeridoComunicacion { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área de comunicación")]
        public string? ApoyoEducativoRequeridoComunicacionDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoAutocuidado { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área de auto cuidado")]
        public string? ApoyoEducativoRequeridoAutocuidadoDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoAcademica { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área académica")]
        public string? ApoyoEducativoRequeridoAcademicaDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoMotriz { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área de ")]
        public string? ApoyoEducativoRequeridoMotrizDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoVisual { get; set; } = 0;
        
        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área visual")]
        public string? ApoyoEducativoRequeridoVisualDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoUtilizacionComunidad { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en la utilización de la comunidad ")]
        public string? ApoyoEducativoRequeridoUtilizacionComunidadDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoFormacionTrabajo { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en el área de formación para el trabajo")]
        public string? ApoyoEducativoRequeridoFormacionTrabajoDescripcion { get; set; }

        public int? ApoyoEducativoRequeridoOtros { get; set; } = 0;

        [DisplayName("Apoyos educativos requeridos para potenciar sus habilidades en otras áreas")]
        public string? ApoyoEducativoRequeridoOtrosDescripcion { get; set; }
        
        // V. Observaciones
        [Required(ErrorMessage = "Se debe especificar si tuvo asesoría previa")]
        [DisplayName("¿Ha recibido asesoría previa?")]
        public int? AsesoriaPrevia { get; set; }

        [Required(ErrorMessage = "Se debe especificar la sede donde se recibió asesoría previa")]
        [DisplayName("Sede donde se recibió la asesoría previa")]
        public string? SedeAsesoriaPrevia { get; set; } = "No aplica";

        [Required]
        [DisplayName("¿Adjunta certificación médica de la Caja Costarricense del Seguro Social (CCSS)?")]
        public int? AdjuntaCertificacionMedicaCCSS { get; set; }

        [Required]
        [DisplayName("¿Adjunta certificación médica de la Consejo Nacional de Personas con Discapcidad (CONAPDIS)?")]
        public int? AdjuntaCertificacionMedicaCONAPDIS { get; set; }

        [Required]
        [DisplayName("¿Ha realizado alguna solicitud previa para obtener productos de apoyo con algún presupuesto de Gobierno?")]
        public int? ProductoApoyoGubernamental { get; set; }

        [DisplayName("Mencione el producto de apoyo solicitado")]
        public string? ProductoApoyoGubernamentalDescripcion { get; set; } = " ";

        [Required]
        [DisplayName("¿Ha realizado alguna solicitud previa para obtener productos de apoyo con algún de Organizaciones No Gubernamentales?")]
        public int? ProductoApoyoNoGubernamental { get; set; }

        [DisplayName("Mencione el producto de apoyo solicitado")]
        public string? ProductoApoyoNoGubernamentalDescripcion { get; set; } = " ";
    }
}
