﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_ContaBancaria {
    class Conta {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
     
       
       
       


        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            
        }

        public Conta(int numero, string titular, double saldo): this(numero, titular){
            
           Saldo = saldo;

        }


        public void Deposito(double quantia) {

            Saldo += quantia;

        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5;
        }


        public override string ToString() {
            return "Conta " + Numero + " Titular: " + Titular + " Saldo: $ " + Saldo;
        }


    }
}
