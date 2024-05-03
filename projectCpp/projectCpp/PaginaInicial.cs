using System;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectCpp;

public partial class PaginaInicial : Form
{
    private SerialPort serialPort;

    public PaginaInicial()
    {
        InitializeComponent();

        // Inicializar a porta serial
        serialPort = new SerialPort();
        serialPort.PortName = "COM3"; // Especifique a porta serial correta
        serialPort.BaudRate = 9600; // Defina a velocidade de transmissão correta
        serialPort.DataReceived += SerialPort_DataReceived; // Evento de recebimento de dados

        try
        {
            serialPort.Open(); // Abre a porta serial
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao abrir a porta serial: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        // Manipular dados recebidos da porta serial
        string dadosRecebidos = serialPort.ReadLine(); // Ler dados da porta serial
        // Faça algo com os dados recebidos, por exemplo, exibir em uma caixa de texto
        textBox1.Invoke(new Action(() => textBox1.AppendText(dadosRecebidos + Environment.NewLine)));
    }

    private void EnviarDadosSerial(string dados)
    {
        try
        {
            serialPort.WriteLine(dados); // Enviar dados pela porta serial
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao enviar dados pela porta serial: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Exemplo de evento de clique de um botão para enviar dados pela porta serial
    private void EnviarBtn_Click(object sender, EventArgs e)
    {
        string dadosParaEnviar = textBox2.Text; // Obter dados do campo de texto
        EnviarDadosSerial(dadosParaEnviar); // Enviar os dados pela porta serial
    }

    // Certifique-se de fechar a porta serial ao fechar o formulário
    private void PaginaInicial_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close(); // Fechar a porta serial
        }
    }
}
