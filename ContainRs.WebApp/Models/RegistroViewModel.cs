using System.ComponentModel.DataAnnotations;

namespace ContainRs.WebApp.Models;

public class RegistroViewModel
{
    [Display(Name ="Nome (*)", Prompt = "Digite seu nome completo.")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string Nome { get; set; }

    [Display(Name = "E-mail (*)", Prompt = "Digite seu melhor e-mail.")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    [EmailAddress(ErrorMessage = "E-mail inválido.")]
    public string Email { get; set; }
//Pode surgir a dúvida sobre transformar a propriedade Email para o tipo Email em RegistroViewModel. 
//No entanto, manteremos essa classe com tipos primitivos, como string, int e boolean, para receber as informações que serão tratadas posteriormente.
//O importante é que, no domínio, essas informações estejam bem representadas.
    [Display(Name = "CPF (*)", Prompt = "000.000.000-00")]
    [Required(ErrorMessage = "Campo obrigatório.")]
    public string CPF { get; set; }
    [Display(Prompt = "(00) 00000-0000")]
    public string? Celular { get; set; }
    [Display(Prompt = "00.000-000")]
    public string? CEP { get; set; }
    public string? Rua { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Municipio { get; set; }
    public string? Estado { get; set; }
}
