using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DispalyName("T�tulo")]
        [Required(ErrorMessage = "Campo obrigat�rio")]
        public string Title { get; set; }

        [DisplayName("Conclu�do")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        [DisplayName("�ltima atualiza��o")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        
        public string User { get; set; }
    }
}