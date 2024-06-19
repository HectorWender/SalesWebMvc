using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // O banco já foi populado
            }

            Department d1 = new Department(101, "Eletrônicos");
            Department d2 = new Department(201, "Eletrodomesticos");
            Department d3 = new Department(301, "Moda");
            Department d4 = new Department(491, "Livraria");

            Seller s1 = new Seller(111, "Roberto", "roberto@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(212, "Maria", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(312, "Alex", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(412, "Marta", "marta@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(512, "Ronaldo", "ronaldo@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(612, "Ana", "ana@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(123, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Faturado, s1);
            SalesRecord r2 = new SalesRecord(223, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Faturado, s5);
            SalesRecord r3 = new SalesRecord(323, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Cancelado, s4);
            SalesRecord r4 = new SalesRecord(423, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Faturado, s1);
            SalesRecord r5 = new SalesRecord(523, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Faturado, s3);
            SalesRecord r6 = new SalesRecord(623, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Pendente, s1);
            SalesRecord r7 = new SalesRecord(723, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Faturado, s2);
            SalesRecord r8 = new SalesRecord(823, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r9 = new SalesRecord(923, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pendente, s6);
            SalesRecord r10 = new SalesRecord(1023, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Cancelado, s6);
            SalesRecord r11 = new SalesRecord(1123, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Faturado, s2);
            SalesRecord r12 = new SalesRecord(1223, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Faturado, s3);
            SalesRecord r13 = new SalesRecord(1323, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Cancelado, s4);
            SalesRecord r14 = new SalesRecord(1423, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Faturado, s5);
            SalesRecord r15 = new SalesRecord(1523, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Faturado, s1);
            SalesRecord r16 = new SalesRecord(1623, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Faturado, s4);
            SalesRecord r17 = new SalesRecord(1723, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Pendente, s1);
            SalesRecord r18 = new SalesRecord(1823, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Faturado, s3);
            SalesRecord r19 = new SalesRecord(1923, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Cancelado, s5);
            SalesRecord r20 = new SalesRecord(2023, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Pendente, s6);
            SalesRecord r21 = new SalesRecord(2123, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Faturado, s2);
            SalesRecord r22 = new SalesRecord(2223, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Faturado, s4);
            SalesRecord r23 = new SalesRecord(2323, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Pendente, s2);
            SalesRecord r24 = new SalesRecord(2423, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Faturado, s5);
            SalesRecord r25 = new SalesRecord(2523, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Cancelado, s3);
            SalesRecord r26 = new SalesRecord(2623, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Faturado, s4);
            SalesRecord r27 = new SalesRecord(2723, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pendente, s1);
            SalesRecord r28 = new SalesRecord(2823, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Faturado, s3);
            SalesRecord r29 = new SalesRecord(2923, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Faturado, s5);
            SalesRecord r30 = new SalesRecord(3023, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Faturado, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
