using System;

namespace Faker.NET.Airline.Data;

public class Airplanes
{
    public static readonly Airplane[] Frames = {
        new Airplane("Antonov An-124 Ruslan","A4F"),
        new Airplane("Antonov An-140","A40"),
        new Airplane("Antonov An-148","A81"),
        new Airplane("Antonov An-158","A58"),
        new Airplane("Airbus A319neo","31N"),
        new Airplane("Airbus A320neo","32N"),
        new Airplane("Airbus A321neo","32Q"),
        new Airplane("Antonov An-225 Mriya","A5F"),
        new Airplane("Airbus A300-600","AB6"),
        new Airplane("Airbus A300-600 Freighter[4]","ABY"),
        new Airplane("Airbus A300B2, A300B4 and A300C4","AB4"),
        new Airplane("Airbus A310-200","312"),
        new Airplane("Airbus A310-300","313"),
        new Airplane("Airbus A318","318"),
        new Airplane("Airbus A318 (sharklets)","32C"),
        new Airplane("Airbus A319","319"),
        new Airplane("Airbus A319 (sharklets)","32D"),
        new Airplane("Airbus A320","320"),
        new Airplane("Airbus A320 (sharklets)","32A"),
        new Airplane("Airbus A321","321"),
        new Airplane("Airbus A321 (sharklets)","32B"),
        new Airplane("Airbus A330-200","332"),
        new Airplane("Airbus A330-300","333"),
        new Airplane("Airbus A330-200 Freighter","33X"),
        new Airplane("Airbus A330-300 Freighter","33Y"),
        new Airplane("Airbus A330-800","338"),
        new Airplane("Airbus A330-900","339"),
        new Airplane("Airbus A340-200","342"),
        new Airplane("Airbus A340-300","343"),
        new Airplane("Airbus A340-500","345"),
        new Airplane("Airbus A340-600","346"),
        new Airplane("Airbus A350-900","359"),
        new Airplane("Airbus A350-1000","351"),
        new Airplane("Airbus A380-800","388"),
        new Airplane("Hawker Siddeley HS 748","HS7"),
        new Airplane("Gulfstream/Rockwell (Aero) Turbo Commander 690","ACT"),
        new Airplane("COMAC ARJ21","C27"),
        new Airplane("Antonov An-12","ANF"),
        new Airplane("Antonov An-24","AN4"),
        new Airplane("Antonov An-26","A26"),
        new Airplane("Antonov An-28","A28"),
        new Airplane("Antonov An-30","A30"),
        new Airplane("Antonov An-32","A32"),
        new Airplane("Antonov An-72 / An-74","AN7"),
        new Airplane("Aerospatiale/Alenia ATR 42-300 / 320","AT4"),
        new Airplane("Aerospatiale/Alenia ATR 42-500","AT5"),
        new Airplane("Aerospatiale/Alenia ATR 42-600","ATR"),
        new Airplane("Aerospatiale/Alenia ATR 72-201/-202","AT7"),
        new Airplane("Aerospatiale/Alenia ATR 72-211/-212","ATR"),
        new Airplane("Aerospatiale/Alenia ATR 72-212A (500)","ATR"),
        new Airplane("Aerospatiale/Alenia ATR 72-212A (600)","ATR"),
        new Airplane("British Aerospace ATP","ATP"),
        new Airplane("Beechcraft 1900","BEH"),
        new Airplane("Boeing 737 MAX 7","7M7"),
        new Airplane("Boeing 737 MAX 8","7M8"),
        new Airplane("Boeing 737 MAX 9","7M9"),
        new Airplane("Boeing 737 MAX 10","7MJ"),
        new Airplane("BAe 146-100","141"),
        new Airplane("BAe 146-200","142"),
        new Airplane("BAe 146-300","143"),
        new Airplane("Boeing 707","703"),
        new Airplane("Boeing 717","717"),
        new Airplane("Boeing 720B","B72"),
        new Airplane("Boeing 727-100","721"),
        new Airplane("Boeing 727-200","722"),
        new Airplane("Boeing 737-200","732"),
        new Airplane("Boeing 737-200 Freighter","73F"),
        new Airplane("Boeing 737-200 Combi[4]","73L"),
        new Airplane("Boeing 737-300","733"),
        new Airplane("Boeing 737-300 Winglets","73C"),
        new Airplane("Boeing 737-300 Freighter","73Y"),
        new Airplane("Boeing 737-400","734"),
        new Airplane("Boeing 737-400 Freighter","73P"),
        new Airplane("Boeing 737-500","735"),
        new Airplane("Boeing 737-500 Winglets","73E"),
        new Airplane("Boeing 737-600","736"),
        new Airplane("Boeing 737-800","738"),
        new Airplane("Boeing 737-900 / Boeing 737-900ER","739"),
        new Airplane("Boeing 737-700 / Boeing 737-700ER","73G"),
        new Airplane("Boeing 737-700 Winglets","73W"),
        new Airplane("Boeing 737-800 Winglets","73H"),
        new Airplane("Boeing 737-800 Freighter Winglets","73K"),
        new Airplane("Boeing 737-800 Freighter","73U"),
        new Airplane("Boeing 737-900 Winglets","73J"),
        new Airplane("Boeing 747-100","741"),
        new Airplane("Boeing 747-100 Freighter","74T"),
        new Airplane("Boeing 747-200","742"),
        new Airplane("Boeing 747-200M","74C"),
        new Airplane("Boeing 747-200F","74X"),
        new Airplane("Boeing 747-300","743"),
        new Airplane("Boeing 747-300M","74D"),
        new Airplane("Boeing 747-400 / Boeing 747-400ER","744"),
        new Airplane("Boeing 747-400M","74E"),
        new Airplane("Boeing 747-400F / Boeing 747-400ERF","74Y"),
        new Airplane("Boeing 747-8I","74H"),
        new Airplane("Boeing 747-8F","74N"),
        new Airplane("Boeing 747SR","74R"),
        new Airplane("Boeing 747SR Freighter","74V"),
        new Airplane("Boeing 747SP","74L"),
        new Airplane("Boeing 757-200","752"),
        new Airplane("Boeing 757F","75F"),
        new Airplane("Boeing 757-200 Winglets[4]","75W"),
        new Airplane("Boeing 757-300","753"),
        new Airplane("Boeing 767-200 / Boeing 767-200ER","762"),
        new Airplane("Boeing 767-200 Freighter / Boeing 767-200ER","76X"),
        new Airplane("Boeing 767-300","763"),
        new Airplane("Boeing 767-300 Winglets / Boeing 767-300ER","76W"),
        new Airplane("Boeing 767-300 Freighter","76Y"),
        new Airplane("Boeing 767-400ER","764"),
        new Airplane("Boeing 777-200 / Boeing 777-200ER","772"),
        new Airplane("Boeing 777-300","773"),
        new Airplane("Boeing 777-8","778"),
        new Airplane("Boeing 777-9","779"),
        new Airplane("Boeing 777-200 Freighter","77X"),
        new Airplane("Boeing 777-200LR","77L"),
        new Airplane("Boeing 777-300ER","77W"),
        new Airplane("Boeing 787-8","788"),
        new Airplane("Boeing 787-9","789"),
        new Airplane("Boeing 787-10","781"),
        new Airplane("British Aerospace (BAC) One Eleven","B11"),
        new Airplane("Airbus A220-100","221"),
        new Airplane("Airbus A220-300","223"),
        new Airplane("Shorts SC-5 Belfast","SHB"),
        new Airplane("Boeing 747-400 LCF Dreamlifter","74B"),
        new Airplane("Lockheed L-182 / 282 / 382 (L-100) Hercules","LOH"),
        new Airplane("CASA / IPTN 212 Aviocar","CS2"),
        new Airplane("Cessna Citation CJ2","CNJ"),
        new Airplane("Cessna Citation CJ3","CNJ"),
        new Airplane("Cessna Citation CJ4","CNJ"),
        new Airplane("Lockheed Martin C-130J Hercules","LOH"),
        new Airplane("Cessna Citation I","CNJ"),
        new Airplane("Cessna Citation Mustang","CNJ"),
        new Airplane("Cessna CitationJet","CNJ"),
        new Airplane("Cessna Citation II","CNJ"),
        new Airplane("Cessna Citation V","CNJ"),
        new Airplane("Cessna Citation Excel","CNJ"),
        new Airplane("Cessna Citation III, VI, VII","CNJ"),
        new Airplane("Cessna Citation Sovereign","CNJ"),
        new Airplane("Cessna Citation Latitude","CNJ"),
        new Airplane("Cessna Citation Longitude","CNJ"),
        new Airplane("Cessna Citation X","CNJ"),
        new Airplane("COMAC C919","919"),
        new Airplane("Canadair Challenger 600","CCJ"),
        new Airplane("CASA/IPTN CN-235","CS5"),
        new Airplane("Canadair Regional Jet 100","CR1"),
        new Airplane("Canadair Regional Jet 200","CR2"),
        new Airplane("Canadair Regional Jet 700 | Regional Jet 550","CR7"),
        new Airplane("Canadair Regional Jet 900","CR9"),
        new Airplane("Canadair Regional Jet 1000","CRK"),
        new Airplane("Convair CV-580, Convair CV-600, Convair CV-640","CV5"),
        new Airplane("Dornier 228","D28"),
        new Airplane("Fairchild Dornier Do.328","D38"),
        new Airplane("Douglas DC-10-10 / -15 Passenger","D11"),
        new Airplane("Douglas DC-10-30 / -40 Passenger","D1C"),
        new Airplane("Douglas DC-10-30 Combi","D1M"),
        new Airplane("Douglas DC-10-10 Freighter","D1X"),
        new Airplane("Douglas DC-10-30 / -40 Freighter","D1Y"),
        new Airplane("Douglas DC-8-50","D8T"),
        new Airplane("Douglas DC-8-62","D8L"),
        new Airplane("Douglas DC-8-72","D8Q"),
        new Airplane("Douglas DC-9-10","D91"),
        new Airplane("Douglas DC-9-20","D92"),
        new Airplane("Douglas DC-9-30","D93"),
        new Airplane("Douglas DC-9-40","D94"),
        new Airplane("Douglas DC-9-50","D95"),
        new Airplane("De Havilland Canada DHC-8-100 Dash 8 / 8Q","DH1"),
        new Airplane("De Havilland Canada DHC-8-200 Dash 8 / 8Q","DH2"),
        new Airplane("De Havilland Canada DHC-8-300 Dash 8 / 8Q","DH3"),
        new Airplane("De Havilland Canada DHC-8-400 Dash 8Q","DH4"),
        new Airplane("De Havilland Canada DHC-5 Buffalo","DHC"),
        new Airplane("De Havilland Canada DHC-6 Twin Otter","DHT"),
        new Airplane("De Havilland Canada DHC-7 Dash 7","DH7"),
        new Airplane("Embraer EMB 110 Bandeirante","EMB"),
        new Airplane("Embraer EMB 120 Brasilia","EM2"),
        new Airplane("Embraer RJ135","ER3"),
        new Airplane("Embraer RJ140","ERD"),
        new Airplane("Embraer RJ145","ER4"),
        new Airplane("Embraer 170","E70"),
        new Airplane("Embraer 190 / Lineage 1000","E90"),
        new Airplane("Embraer 195","E95"),
        new Airplane("Embraer E190-E2","290"),
        new Airplane("Embraer E195-E2","295"),
        new Airplane("Embraer Legacy 600 / Legacy 650","ER3"),
        new Airplane("Embraer Phenom 100","EP1"),
        new Airplane("Embraer Phenom 300","EP3"),
        new Airplane("Embraer 175 (long wing)","E7W"),
        new Airplane("Embraer 175 (short wing)","E75"),
        new Airplane("Fokker 100","100"),
        new Airplane("Fokker F27 Friendship","F27"),
        new Airplane("Fokker F28 Fellowship","F21"),
        new Airplane("Dassault Falcon 2000","D20"),
        new Airplane("Reims-Cessna F406 Caravan II","CNT"),
        new Airplane("Fokker 50","F50"),
        new Airplane("Fokker 70","F70"),
        new Airplane("Dassault Falcon 900","DF9"),
        new Airplane("Dassault Falcon 50","DF3"),
        new Airplane("Dassault Falcon 7X","DF7"),
        new Airplane("Gulfstream Aerospace G-159 Gulfstream I","GRS"),
        new Airplane("Gulfstream G280","GR3"),
        new Airplane("Grumman G-73 Turbo Mallard","GRM"),
        new Airplane("Bombardier BD-700 Global 5000","CCX"),
        new Airplane("Bombardier Global Express / Raytheon Sentinel","CCX"),
        new Airplane("Gulfstream IV","GJ4"),
        new Airplane("Gulfstream V","GJ5"),
        new Airplane("Gulfstream G650","GJ6"),
        new Airplane("British Aerospace 125 series / Hawker/Raytheon 700/800/800XP/850/900","H25"),
        new Airplane("British Aerospace 125-1000 series / Hawker/Raytheon 1000","H25"),
        new Airplane("Honda HA-420","HHJ"),
        new Airplane("Ilyushin Il-114","I14"),
        new Airplane("Ilyushin Il-18","IL8"),
        new Airplane("Ilyushin Il-62","IL6"),
        new Airplane("Ilyushin Il-76","IL7"),
        new Airplane("Ilyushin Il-86","ILW"),
        new Airplane("Ilyushin Il-96","I93"),
        new Airplane("Fairchild Dornier 328JET","FRJ"),
        new Airplane("British Aerospace Jetstream 31","J31"),
        new Airplane("British Aerospace Jetstream 32","J32"),
        new Airplane("British Aerospace Jetstream 41","J41"),
        new Airplane("Boeing KC-135 Stratotanker","K35"),
        new Airplane("Lockheed L-1011 Tristar","L10"),
        new Airplane("Lockheed L-188 Electra","LOE"),
        new Airplane("LET 410","L4T"),
        new Airplane("Learjet 35 / 36 / C-21A","LRJ"),
        new Airplane("Learjet 60","LRJ"),
        new Airplane("McDonnell Douglas MD-11","M11"),
        new Airplane("McDonnell Douglas MD-11F","M1F"),
        new Airplane("McDonnell Douglas MD-11C","M1M"),
        new Airplane("McDonnell Douglas MD-81","M81"),
        new Airplane("McDonnell Douglas MD-82","M82"),
        new Airplane("McDonnell Douglas MD-83","M83"),
        new Airplane("McDonnell Douglas MD-87","M87"),
        new Airplane("McDonnell Douglas MD-88","M88"),
        new Airplane("McDonnell Douglas MD-90","M90"),
        new Airplane("Mitsubishi Mu-2","MU2"),
        new Airplane("Aerospatiale (Nord) 262","ND2"),
        new Airplane("Government Aircraft Factories N22B / N24A Nomad","CD2"),
        new Airplane("Piaggio P.180 Avanti","P18"),
        new Airplane("Pilatus PC-24","PL4"),
        new Airplane("Avro RJ100","AR1"),
        new Airplane("Avro RJ70","AR7"),
        new Airplane("Avro RJ85","AR8"),
        new Airplane("Aerospatiale SN.601 Corvette","NDC"),
        new Airplane("Saab 2000","S20"),
        new Airplane("Shorts SC-7 Skyvan","SHS"),
        new Airplane("Saab SF340A/B","SF3"),
        new Airplane("Shorts SD.330","SH3"),
        new Airplane("Shorts SD.360","SH6"),
        new Airplane("Sukhoi Superjet 100-95","SU9"),
        new Airplane("Fairchild Swearingen Metroliner","SW4"),
        new Airplane("Tupolev Tu-134","TU3"),
        new Airplane("Tupolev Tu-154","TU5"),
        new Airplane("Tupolev Tu-204 / Tu-214","T20"),
        new Airplane("Israel Aircraft Industries 1124 Westwind","WWP"),
        new Airplane("Harbin Y-12","YN2"),
        new Airplane("Yakovlev Yak-40","YK4"),
        new Airplane("Yakovlev Yak-42","YK2"),
        new Airplane("NAMC YS-11","YS1"),
    };
}
