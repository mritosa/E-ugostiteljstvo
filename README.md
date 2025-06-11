# Sustav za upravljanje količinom namirnica u ugostiteljstvu


## Opis domene
U ugostiteljstvu dolazi do problema organizacije narmirnica. Glavni kuhari često moraju voditi računa o količini namirnica na skladištu i ponekad im je teško procjeniti koliko namirnica troše i koju količinu namirnica trebaju naručiti. Zbog toga dolazi do bacanja hrane zbog prevelikih narudžba ili nedostatka namirnica za kuhanje jela. Zbog tih problema odlučili smo ugostiteljima olakšati proces nabave i upravljanja količinom namirnica.
## Specifikacija projekta


Pristup ovom softveru će imati računovodstvo ugostiteljskih objekata i osobe nadležne za upravljanjem količinama namirnica u kuhinji(glavni kuhar/ica, slastičar, mesar). Njima će biti podjeljene uloge,  te ovisno o tome imat će pristup različitim funkcionalnostima u aplikaciji. Svima će biti omogućen pregled namirnica, a osobama nadležnim za naručivanje namirnica biti omogućena izrada narudženice koja će biti proslijeđena računovodstvu. Naša će aplikacija omogućiti korisnicima omogućiti bilježenje dnevnih potrošenih namirnica. Računovodstvu će biti omogućen pregled svih narudžbenica te izrada izvještaja o novčanoj potrošnji, količini iskorištenih i ukupnoj količini namirnica.

Oznaka | Naziv | Kratki opis | 
------ | ----- | ----------- |
F01 | Login i Registracija | Za pristup sustavu potrebna je registracija korisnika u sustav i njegova prijava. Prijava će biti omoguće pomoću skeniranja lica. | 
F02 | Unos u katalog namirnica | Korisnik će imati mogućnost unošenja tj, kreiranja namirnica. Svaka namirnica će imati vlasiti generirani QR kod s kojim će se pratiti kretanje namirnice u ugostiteljskom objektu. | 
F03 | Pregled namirnica | Korisnicima će biti omogućeno pretraživanje, sortiranje i filtriranje po različitim kriterijima sve namirnice na skladištu. | 
F04 | Kreiranje narudžbenice | Korisnicima će biti omogućeno dodavanje, brisanje, i izmjena količine namirnica u narudžbenici. Narudžbenica će se moći kreirati ručno (ručnim dodavanjem stavku po stavku) ili automatski (softver prepoznaje koji artikli su pali ispod minimalnih zaliha i kreiraju stavke sa količinama dostatnim da se dođe do optimalne količine). | 
F05 | Unos potrošenih namirnica | Korisnicima će biti omogućeno izdavanje namirnica u kuhinji(pri tome se generira i ispisuje dokument izdatnica). Namirnice se dodaju u stavke izdatnice korištenjem QR koda na namirnici.  | 
F06 | Pregled narudžbenica | Korisnici koji će biti prijavljeni s ulogom računovodstva će imati mogućnost pretraživanja, sortiranja i filtriranja po različitim kriterijima sve narudžbenice. Uz to biti će omogućen prikaz detalja pojedine narudžbenice te njen ispis u obliku PDF dokumenta. |
F07 | Generiranje izvještaja namirnica kojima se bliži rok trajanja | Korisnici koji će biti prijavljeni s ulogom računovodstva  imati će mogućnost generiranja i ispis izvještaja sa popisom namirnica kojima se bliži rok uporabe. | 
F08 | Izrada primke | Korisnici koji će biti prijavljeni s ulogom računovodstva imati mogućnost mogućnost zaprimanja namirnica na temelju izrađene narudžbenice. Sa narudžbenice se automatski dodaju stavke na primku. | 
F09 | Statistika iskorištenosti namirnica  | Sustav će računovodstvu omogućiti kreirati statistički izvještaj o iskorištenosti namirnica tokom svakog mjeseca u tekućoj godini te prikaz namirnica kojima je prošao rok. | 

## Tehnologije i oprema
Visual studio Code 2022, Visual Paradigm, Figma, Github...
