using Microsoft.EntityFrameworkCore;
using MODELO.Auditoria;
using MODELO.Composite;
using MODELO.Imagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Context : DbContext
    {
        private string cadena_conexion = "Data Source=LAPTOP-4N09G2SQ\\SQLEXPRESS;Initial Catalog=Sistema_IDS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Command Timeout=0";

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cabaña> Cabañas { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<ImagenCabaña> ImagenesCabaña { get; set; }
        public DbSet<MotivoCancelacion> MotivosCancelacion { get; set; }
        public DbSet<UsuarioAuditoria> UsuariosAuditoria { get; set; }
        public DbSet<ClienteAuditoria> ClientesAuditoria { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<ImagenServicio> ImagenesServicio { get; set; }
        public DbSet<ImagenMantenimiento> ImagenesMantenimiento { get; set; }
        public DbSet<RolEmpleado> RolesEmpleados { get; set; }
        public DbSet<AsignacionServicio> AsignacionesServicio { get; set; }
        public DbSet<MotivoCancelacionServicio> MotivosCancelacionServicio { get; set; }
        public DbSet<AsignacionMantenimiento> AsignacionesMantenimiento { get; set; }
        public DbSet<MotivoCancelacionMantenimiento> MotivosCancelacionMantenimiento { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(cadena_conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Grupo>()
                .HasMany(g => g.Permisos)
                .WithMany(p => p.Grupos)
                .UsingEntity(j => j.ToTable("GrupoPermisos"));

            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Grupo)
                .WithMany()
                .HasForeignKey(u => u.GrupoId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>()
            .Property(u => u.Contraseña)
            .IsRequired(false);

            modelBuilder.Entity<Reserva>()
            .HasMany(r => r.MotivosCancelacion)
            .WithMany(m => m.Reservas)
            .UsingEntity(j => j.ToTable("ReservaMotivoCancelacion"));

            modelBuilder.Entity<Servicio>()
            .HasMany(s => s.Categorias)
            .WithMany(c => c.Servicios)
            .UsingEntity(j => j.ToTable("ServiciosCategorias"));

            modelBuilder.Entity<Servicio>()
            .HasMany(s => s.Imagenes)
            .WithOne(i => i.Servicio)
            .HasForeignKey(i => i.ServicioId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AsignacionServicio>()
            .HasOne(a => a.Servicio)
            .WithMany()
            .HasForeignKey(a => a.ServicioId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AsignacionServicio>()
            .HasOne(a => a.Reserva)
            .WithMany()
            .HasForeignKey(a => a.ReservaId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AsignacionServicio>()
            .HasMany(a => a.MotivosCancelacion)
            .WithMany(m => m.AsignacionesServicio)
            .UsingEntity(j => j.ToTable("AsignacionServicioMotivoCancelacion"));

            modelBuilder.Entity<AsignacionMantenimiento>()
            .HasOne(a => a.Mantenimiento)
            .WithMany()
            .HasForeignKey(a => a.MantenimientoId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AsignacionMantenimiento>()
            .HasOne(a => a.Cabaña)
            .WithMany()
            .HasForeignKey(a => a.CabañaId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AsignacionMantenimiento>()
            .HasOne(a => a.Empleado)
            .WithMany()
            .HasForeignKey(a => a.EmpleadoId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AsignacionMantenimiento>()
            .HasMany(a => a.MotivosCancelacion)
            .WithMany(m => m.AsignacionesMantenimiento)
            .UsingEntity(j => j.ToTable("AsignacionMantenimientoMotivoCancelacion"));

        }

    }
}
