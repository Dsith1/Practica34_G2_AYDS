create procedure CrearUsuario(
@dpi_i varchar(13), @nombres_i varchar(30), @apellidos_i varchar(30), @correo_i varchar(20), @password_i varchar(20)
)

as
insert into usuario(dpi,nombres,apellidos,correo,password)
              values(@dpi_i,@nombres_i, @apellidos_i,@correo_i, @password_i);