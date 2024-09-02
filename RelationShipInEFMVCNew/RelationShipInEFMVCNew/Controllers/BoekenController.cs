﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Data;
using OneToManyDemo.Models;
using OneToManyDemo.Models.ViewModels;


namespace OneToManyDemo.Controllers
{
    public class BoekenController : Controller
    {
        readonly BoekenDbContext _context;
        public BoekenController(BoekenDbContext dbContext)
        {
                _context = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var boekAuteurViewModel = _context.Boeks
                .Include(b => b.Auteur)
                .Select(b => new BoekAuteurViewModel
                {
                    BoekId = b.BoekId,
                    Titel = b.Titel,
                    AuteurNaam = b.Auteur.Naam
                });

            return View(boekAuteurViewModel);
        }

        public async Task<IActionResult> Filters(int? GeselecteerdeAuteurId)
        {
            var auteurs = await _context.Auteurs.ToListAsync();

            IQueryable<Boek> boekenQuery = _context.Boeks.Include(b => b.Auteur);

            if (GeselecteerdeAuteurId.HasValue)
            {
                boekenQuery = boekenQuery.Where(b => b.AuteurId == GeselecteerdeAuteurId);
            }

            var boeken = await boekenQuery.ToListAsync();

            var boekenViewModel = boeken.Select(b => new BoekAuteurViewModel
            {
                BoekId = b.BoekId,
                Titel = b.Titel,
                AuteurNaam = b.Auteur.Naam
            }).ToList();

            var filtersViewModel = new Models.ViewModels.BoekenViewModel
            {
                Auteurs = auteurs,
                Boeken = boekenViewModel,
                GeselecteerdeAuteurId = GeselecteerdeAuteurId ?? 0
            };



            return View(filtersViewModel);
        }
    }

    internal class BoekAuteurViewModel
    {
        public int BoekId { get; set; }
        public string Titel { get; set; }
        public string AuteurNaam { get; set; }
    }
}
