namespace CelularPOO
{

//     Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
// Envie o link do repositório como entrega desta atividade.
    public class Celular
    {
        public string corCelular;
        public string modeloCelular;
        public double tamanhoCelular;
        public bool estadoCelular = false;

        public bool ligar(){
            estadoCelular = true;
            return estadoCelular;
        }

        public bool desligar(){
            estadoCelular = false;
            return estadoCelular;
        }

        public string menu(string modelo){
            string menu =$@"
             ______________________
            |                       |
                    {modelo}        
            |                       |
            |                       |
            |                       |
            |         MENU          |
            |                       |
            |  [1] Fazer ligação    |                     
            |                       | 
            |  [2] Enviar Mensagem  |
            |                       |
            |  [3] Desligar         |
            |                       |
            |                       |
            |                       |
            |                       |
            |                       |
            |                       |
            |_______________________|
            
            ";
            return menu;
        }

        public string fazerLigacao(string pessoa){
            string ligando = $@"
             _______________________
            |                       |
                    {pessoa}        
            |                       |
            |                       |
            |                       |
            |  O telefone está      |
            | impossibilitado de    |
            | receber este tipo de  |
            | chamada nesse momento |                     
            |                       |
            |                       |
            |                       |
            |         o  o          |
            |         ----          |
            |                       |
            |                       |
            |                       |
            |                       |
            |_______________________|
            ";
            return ligando;
        }

        public string enviarMensagem(string mensagem, string pessoa){
            string chat = $@"
             ______________________
            |                       |
                    Mensagem 
                    {pessoa}
            |                       |
            |                       |
            |  ---------------------|
            |  |{mensagem}                maximo 20
            |  ---------------------|                     
            |                       | 
            |                       |
            |                       |
            |                       |
            |---------------        |
            | Não posso    |        |
            | responder agr|        |
            |---------------        |
            |                       |
            |                       |
            |_______________________|
            
            ";
            return chat;
        }
    }
}