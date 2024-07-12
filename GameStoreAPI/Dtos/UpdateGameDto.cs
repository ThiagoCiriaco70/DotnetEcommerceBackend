using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GameStoreAPI.Dtos;

public record class UpdateGameDto(
  [Required][StringLength(50)] string Name,
  int GenreId,
  [Range(0,100)] decimal Price,
  DateOnly ReleaseDate
);
