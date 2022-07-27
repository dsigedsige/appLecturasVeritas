using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSIGE.Modelo
{
   public class ImportarArchivoPlano
    {
        public string Item { get; set; }
        public string Instalacion { get; set; }
        public string Equipo { get; set; }
        public string Aparato { get; set; }
        public string Tipo_calle { get; set; }
        public string Nombre_Calle { get; set; }
        public string Altura_Calle { get; set; }
        public string Numero_Edificio { get; set; }
        public string Numero_Departamento { get; set; }
        public string Detalle_adicional_ubicacion { get; set; }
        public string Piso { get; set; }
        public string Vivienda_Principal { get; set; }
        public string Detalle_Construccion { get; set; }
        public string Conjunto_Vivienda { get; set; }
        public string Manzana_Lote { get; set; }
        public string Distrito { get; set; }
        public string Codigo_postal { get; set; }
        public string Poblacion { get; set; }
        public string Emplazamiento { get; set; }
        public string Suplemento_emplazamiento { get; set; }
        public string Lectura_anterior { get; set; }
        public string Fecha_planificada_lectura_anterior { get; set; }
        public string Fecha_planificada_lectura_actual { get; set; }
        public string Fecha_planificada_lectura_proxima { get; set; }
        public string Interlocutor_comercial { get; set; }
        public string Cuenta_contrato { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Categoria { get; set; }
        public string Secuencia_lectura { get; set; }
        public string Unidad_lectura { get; set; }
        public string Numero_lecturas_estimadas { get; set; }
        public string Marca_primera_lectura { get; set; }
        public string Empresa_Lectora { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Cliente { get; set; }
        public string Nota_ubicacion_aparato { get; set; }
        public string Nota_dos_ubicacion_aparato { get; set; }
        public string Secuencia { get; set; }

        public string nombre_ArchivoImportado { get; set; }
        public string fecha_Asignacion { get; set; }
        public string id_TipoServicio { get; set; }       

    }

    public class ImportarArchivoPlano_new
    {
        public string Item { get; set; }
        public string Instalacion { get; set; }
        public string Equipo { get; set; }
        public string Aparato { get; set; }
        public string Tipo_calle { get; set; }
        public string Nombre_Calle { get; set; }
        public string Altura_Calle { get; set; }
        public string Numero_Edificio { get; set; }
        public string Numero_Departamento { get; set; }
        public string Detalle_adicional_ubicacion { get; set; }
        public string Piso { get; set; }
        public string Vivienda_Principal { get; set; }
        public string Detalle_Construccion { get; set; }
        public string Conjunto_Vivienda { get; set; }
        public string Manzana_Lote { get; set; }
        public string Distrito { get; set; }
        public string Codigo_postal { get; set; }
        public string Poblacion { get; set; }
        public string Emplazamiento { get; set; }
        public string Suplemento_emplazamiento { get; set; }
        public string Lectura_anterior { get; set; }
        public string Fecha_planificada_lectura_anterior { get; set; }
        public string Fecha_planificada_lectura_actual { get; set; }
        public string Fecha_planificada_lectura_proxima { get; set; }
        public string Interlocutor_comercial { get; set; }
        public string Cuenta_contrato { get; set; }
        public string Tipo_Cliente { get; set; }
        public string Categoria { get; set; }
        public string Secuencia_lectura { get; set; }
        public string Unidad_lectura { get; set; }
        public string Numero_lecturas_estimadas { get; set; }
        public string Marca_primera_lectura { get; set; }
        public string Empresa_Lectora { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Cliente { get; set; }
        public string Nota_ubicacion_aparato { get; set; }
        public string Nota_dos_ubicacion_aparato { get; set; }
        public string Secuencia { get; set; }

        public string estado_instalacion { get; set; }
        public string lectura_corte { get; set; }
        public string lectura_maxima { get; set; }
        public string lectura_minima { get; set; }
        public string estado_contrato { get; set; }
        public string lectura_inmediata_ant { get; set; }

        public string latitud { get; set; }
        public string longitud { get; set; }

        public string nombre_ArchivoImportado { get; set; }
        public string fecha_Asignacion { get; set; }
        public string id_TipoServicio { get; set; }

    }

    public class ImportarTXT_E
    {
        public string ID_interno_doc_lec { get; set; }
        public string Numero_consecutivo { get; set; }
        public string Instalacion { get; set; }
        public string Aparato { get; set; }
        public string Tipo_calle { get; set; }
        public string Calle { get; set; }
        public string Nro_edificio { get; set; }
        public string Sigla_edificio { get; set; }
        public string Nro_habitacion { get; set; }
        public string Detal_ubicacion { get; set; }
        public string Cant_pisos { get; set; }
        public string Vivienda_ppal { get; set; }
        public string Det_construccion { get; set; }
        public string Conjunto_vivienda { get; set; }
        public string Manzana_lote { get; set; }
        public string Distrito { get; set; }
        public string Codigo_postal { get; set; }
        public string Poblacion { get; set; }
        public string Emplazamiento { get; set; }
        public string F_planifica_lec_anterior { get; set; }
        public string Fe_lect_plan { get; set; }
        public string Cuenta_contrato { get; set; }
        public string Categoria_cuenta { get; set; }
        public string Tipo_tarifa { get; set; }
        public string Secuencia_lectura { get; set; }
        public string Unidad_lectura { get; set; }
        public string Numero_lecturas_estimadas_consecutiva { get; set; }
        public string Marca_primera_lectura { get; set; }
        public string Empresa_externa { get; set; }
        public string Nota { get; set; }
        public string Nombre_completo { get; set; }
        public string Telefono { get; set; }
        public string Cod_Mz { get; set; }
        public string Cod_Lt { get; set; }
        public string Estado_instala { get; set; }
        public string Lectura_corte { get; set; }
        public string Lec_maxima_permitida { get; set; }
        public string Lec_minima_permitida { get; set; }
        public string Coor_X_Latit { get; set; }
        public string Coor_Y_Long { get; set; }
        public string Porcion { get; set; }
        public string Unidad_predial_clic { get; set; }
        public string Sociedad { get; set; }
        public string Motivo_lectura { get; set; }
        public string Consumo_prom_dia { get; set; }
        public string Consumo_prom_mes { get; set; }
        public string Fecha_carga { get; set; }
        public string Hora_descarga { get; set; }

        public string nombre_ArchivoImportado { get; set; }
        public string fecha_Asignacion { get; set; }
        public string id_TipoServicio { get; set; }

    }


}
