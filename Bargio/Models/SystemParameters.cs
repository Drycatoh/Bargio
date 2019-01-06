﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bargio.Models
{
    public class SystemParameters
    {
        [Key]
        public string Id { get; set; }
        [DisplayName("Dernière connexion à la babasse")]
        public DateTime DerniereConnexionBabasse { get; set; }
        [DisplayName("Bloquer les bucquages")]
        public bool BucquagesBloques { get; set; }
        [DisplayName("Bloquer les rechargements en ligne")]
        public bool LydiaBloque { get; set; }
        [DisplayName("Mode maintenance  -- /!\\ Cette page deviendra inaccessible")]
        public bool Maintenance { get; set; }

        /* Paramètre zifoy'ss de la babasse */
        [DisplayName("Activer la mise hors babasse automatique")]
        public bool MiseHorsBabasseAutoActivee { get; set; }
        [DisplayName("Seuil de mise hors babasse automatique")]
        public decimal MiseHorsBabasseSeuil { get; set; }
        [DisplayName("Mise hors babasse auto instantanée (plutôt que périodique)")]
        // Instantanée ou périodique
        public bool MiseHorsBabasseInstantanee { get; set; }
        [DisplayName("Si périodique, mise hors babasse quotidienne (plutôt qu'hebdomadaire)")]
        // Quotidienne ou hebdomadaire
        public bool MiseHorsBabasseQuotidienne { get; set; }
        [DisplayName("Heure pour la mise hors babasse quotidienne si activée")]
        public string MiseHorsBabasseQuotidienneHeure { get; set; }
        [DisplayName("Jour(s) pour la mise hors babasse hebdomadaire si activée")]
        public string MiseHorsBabasseHebdomadaireJours { get; set; }
        [DisplayName("Heure pour chaque jour de la mise hors babasse hebdomadaire si activée")]
        public string MiseHorsBabasseHebdomadaireHeure { get; set; }
        [DisplayName("Mot de passe zifoys")]
        public string MotDePasseZifoys { get; set; }

        
        [DisplayName("Mot des Zifoys")]
        public string MotDesZifoys { get; set; }
        [DisplayName("Actualités")]
        public string Actualites { get; set; }
        [DisplayName("Oh, il neige !")]
        public bool Snow { get; set; }
    }
}
