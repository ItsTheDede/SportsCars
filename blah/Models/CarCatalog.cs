namespace blah.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Slug { get; set; } = default!;   // ex: "ferrari-sf90-xx"
        public string Name { get; set; } = default!;
        public string ImagePath { get; set; } = default!;
        public string Model3dPath { get; set; } = default!;
        public decimal Price { get; set; }
        public string? PossibleModificationsJson { get; set; } // lista guardada em JSON
    }

    public static class CarCatalog
    {
        public static readonly IReadOnlyDictionary<string, CarDetailViewModel> Cars = new Dictionary<string, CarDetailViewModel>
        {
            ["porsche-911-gt3-rs"] = new CarDetailViewModel
            {
                Id = "porsche-911-gt3-rs",
                Name = "Porsche 911 GT3 RS",
                ImagePath = "/images/carro-1.jpg",
                Model3dPath = "/models/porsche_gt3_rs.glb",
                Price = 320000m,
                PossibleModifications = new()
                {
                    "Escape em titânio com válvula para reduzir peso e melhorar fluxo",
                    "Reprogramação ECU Stage 1 com mapa focado em pista",
                    "Coilovers ajustáveis (altura, compressão e retorno)",
                    "Pastilhas de travão de alta temperatura e fluido DOT performance",
                    "Jantes forjadas leves com pneus semi-slick"
                }
            },
            ["toyota-supra-mk4"] = new CarDetailViewModel
            {
                Id = "toyota-supra-mk4",
                Name = "Toyota Supra MK4",
                ImagePath = "/images/carro-2.jpg",
                Model3dPath = "/models/toyota_supra_mk4__supra_1997__free_download.glb",
                Price = 95000m,
                PossibleModifications = new()
                {
                    "Turbo single upgrade com coletor tubular",
                    "Sistema de combustível maior (bomba, injetores e regulador)",
                    "Intercooler frontal de maior capacidade",
                    "LSD (diferencial autoblocante) para melhor tração",
                    "Kit de travões maiores e linhas em malha de aço"
                }
            },
            ["porsche-911-carrera-4s"] = new CarDetailViewModel
            {
                Id = "porsche-911-carrera-4s",
                Name = "Porsche 911 Carrera 4S",
                ImagePath = "/images/carro-3.jpg",
                Model3dPath = "/models/2019_porsche_911_carrera_4s_992.glb",
                Price = 145000m,
                PossibleModifications = new()
                {
                    "Escape desportivo com válvulas ativas",
                    "Reprogramação ECU Stage 1",
                    "Suspensão rebaixada desportiva",
                    "Jantes forjadas Vossen",
                    "Kit aerodinâmico em fibra de carbono"
                }
            },
            ["honda-civic-type-r"] = new CarDetailViewModel
            {
                Id = "honda-civic-type-r",
                Name = "Honda Civic Type-R",
                ImagePath = "/images/carro-4.jpg",
                Model3dPath = "/models/2023_honda_civic_type_r.glb",
                Price = 58000m,
                PossibleModifications = new()
                {
                    "Admissão de ar frio e inlet de maior fluxo",
                    "Reflash ECU Stage 1 para melhor resposta do turbo",
                    "Cat-back performance mantendo uso diário",
                    "Camber arms e alinhamento para melhor entrada em curva",
                    "Pastilhas desportivas e discos ranhurados"
                }
            },
            ["nissan-gtr-r34"] = new CarDetailViewModel
            {
                Id = "nissan-gtr-r34",
                Name = "Nissan GTR R34",
                ImagePath = "/images/carro-5.jpg",
                Model3dPath = "/models/nissan_gtr_r34_skyline__gt-r_skyline.glb",
                Price = 260000m,
                PossibleModifications = new()

                {
                    "Twin turbo upgrade com wastegates externas",
                    "ECU standalone com afinação em dinamómetro",
                    "Injetores maiores e bomba de combustível reforçada",
                    "Sistema de travagem big brake kit",
                    "Suspensão ajustável e barras anti-aproximação"
                }
            },
            ["mclaren-artura-2023"] = new CarDetailViewModel
            {
                Id = "mclaren-artura-2023",
                Name = "McLaren Artura",
                ImagePath = "/images/carro-7.jpg",
                Model3dPath = "/models/2023_mclaren_artura.glb",
                Price = 255000m,
                PossibleModifications = new()
                {
                    "Downpipes e escape em titânio para melhor fluxo e som",
                    "Reprogramação ECU Stage 1 para resposta mais rápida",
                    "Suspensão ajustável com setup street/track",
                    "Jantes forjadas leves com pneus ultra-performance",
                    "Upgrade de travagem com pastilhas e fluido de alta temperatura"
                }
            },
            ["ferrari-812-gts-2020"] = new CarDetailViewModel
            {
                Id = "ferrari-812-gts-2020",
                Name = "Ferrari 812 GTS",
                ImagePath = "/images/carro-10.jpg",
                Model3dPath = "/models/2020_ferrari_812_gts.glb",
                Price = 420000m,
                PossibleModifications = new()
                {
                    "Escape em inox/titânio com válvulas para melhor som V12",
                    "Reprogramação ECU Stage 1 com foco em resposta de acelerador",
                    "Suspensão ajustável para compromisso estrada/pista",
                    "Jantes forjadas leves com pneus de alta performance",
                    "Travagem performance com pastilhas e fluido de competição"
                }
            },
            ["audi-r8-v10-performance-quattro"] = new CarDetailViewModel
            {
                Id = "audi-r8-v10-performance-quattro",
                Name = "Audi R8",
                ImagePath = "/images/carro-8.jpg",
                Model3dPath = "/models/2019_audi_r8_v10_performance_quattro.glb",
                Price = 235000m,
                PossibleModifications = new()
                {
                    "Escape valvetronic em inox para som e fluxo melhorado",
                    "Reprogramação ECU Stage 1 com foco em resposta linear",
                    "Suspensão ajustável para setup street/track",
                    "Jantes forjadas leves com pneus performance",
                    "Kit de travagem com pastilhas e fluido de alta temperatura"
                }
            },
            ["bmw-m4-competition"] = new CarDetailViewModel
            {
                Id = "bmw-m4-competition",
                Name = "BMW M4 Competition",
                ImagePath = "/images/carro-9.jpg",
                Model3dPath = "/models/2026_bmw_m4_competition.glb",
                Price = 128000m,
                PossibleModifications = new()
                {
                    "Downpipes e cat-back performance com válvulas",
                    "Reprogramação ECU Stage 1 com foco em fiabilidade",
                    "Intercooler de maior capacidade para uso intensivo",
                    "Suspensão coilover ajustável para estrada e pista",
                    "Jantes forjadas com pneus ultra-high-performance"
                }
            },
            ["subaru-sti"] = new CarDetailViewModel
            {
                Id = "subaru-sti",
                Name = "Subaru STI",
                ImagePath = "/images/carro-6.jpg",
                Model3dPath = "/models/2012_varis_subaru_impreza_wrx_sti_grb_ver.glb",
                Price = 52000m,
                PossibleModifications = new()
                {
                    "Up-pipe/downpipe e escape completo de alto fluxo",
                    "Remap ECU para aumento de potência com segurança",
                    "Intercooler maior para estabilidade térmica",
                    "Bomba de combustível e injetores de maior débito",
                    "Buchas e barras estabilizadoras para melhor comportamento"
                }
            },
            ["ferrari-sf90-xx"] = new CarDetailViewModel
            {
                Id = "ferrari-sf90-xx",
                Name = "Ferrari SF90 XX",
                ImagePath = "/images/carro-12.jpg",
                Model3dPath = "/models/2023_ferrari_sf90_xx_stradale.glb",
                Price = 480000m,
                PossibleModifications = new()
                {
                    "Escape em titânio de alto fluxo para realçar o som do V8 híbrido",
                    "Reprogramação ECU/hybrid control para resposta mais agressiva em pista",
                    "Suspensão ajustável dedicada a track-days",
                    "Jantes forjadas ultraleves com pneus semi-slick",
                    "Upgrade de travagem com discos carbocerâmicos ventilados e fluido racing"
                }
            }
        };
    }
}