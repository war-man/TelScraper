﻿using System.Collections.Generic;

namespace TelScraper.Test
{
    class TestSampleData
    {
        public static readonly Dictionary<string, string> RawHtmlSamplesByCountry = new Dictionary<string, string>()
        {
            { "GER", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:01234123456\">01234 123456</a>" +
                "<a href=\"tel:01234123456\">01234-123456</a>" +
                "<a href=\"tel:01234123456\">01234/123456</a>" +
                "<a href=\"tel:0123412345612\">01234/123456-12</a>" +
                "<a href=\"tel:01234123456\">(01234) 123456</a>" +
                "<a href=\"tel:0123412345612\">01234 123456-12</a>" +
                "<a href=\"tel:+491234123456\">+49 1234 123456</a>" +
                "<a href=\"tel:+491234123456\">+49 (1234) 123456</a>" +
                "<a href=\"tel:123412121212\">1234 - 12 12 12 12</a>" +
                "<a href=\"tel:+49891234567\">+49 8 91 23 45-67</a>" +
                "<a href=\"tel:+49891234567\">+49 89 1 23 45-67</a>" +
                "<a href=\"tel:+49891234567\">+49 (89) 1 23 45-67</a>" +
                "<a href=\"tel:+490897485640\">+49 (0 89) 74 85 64-0</a>" +
                "<a href=\"tel:+490897485640\">+49 (089) 748564-0</a>" +
                "<a href=\"tel:+490897485640\">+49 (0) 89 74 85 64-0</a>" +
                "<a href=\"tel:+49051326688\">+49 (05132) 6688</a>" +
                "<a href=\"tel:+4951326688\">+49 (5132) 6688</a>" +
                "<a href=\"tel:+49121212121212\">+ 49 12 12 / 12 12 - 12 12</a>" +
                "<a href=\"tel:+49121212121212\">+49 12 12 / 12 12 - 12 12</a>" +
                "<a href=\"tel:+330296141133\">+33 (0) 296 14 11 33</a>" +
                "<a href=\"tel:+33296141133\">+33 296 14 11 33</a>" +
                "<a href=\"tel:+4951153520\">+49 511 5352-0</a>" +
                "<a href=\"tel:+493062901110\">+49 30 6290111-0</a>" +
                "<a href=\"tel:+04064610\">040 - 64 61 - 0</a>" +
                "<a href=\"tel:+49022117739777\">+49 (0)221 - 177 39 777</a>" +
                "<a href=\"tel:0216149040\">(0 21 61) 49 04 - 0</a>" +
                "<a href=\"tel:08005035418\">0800 / 5 03 54 18</a>" +
                "<a href=\"tel:08003300556\">0800 / 33 00 556</a>" +
                "<a href=\"tel:04063770\">(040) 63 77 - 0</a>" +
                "<a href=\"tel:08004353361\">0800 - 43 53 361</a>" +
                "<a href=\"tel:040380800\">040 38080-0</a>" +
                "<a href=\"tel:04032800\">(040) 3280-0</a>" +
                "<a href=\"tel:+49241801\">+49 241 80 1</a>" +
                "</body></html>" },
            { "CA",  "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1232121234\">123-212-1234</a>" +
                "<a href=\"tel:2121234\">212-1234</a>" +
                "<a href=\"tel:11232121234\">1-123-212-1234</a>" +
                "<a href=\"tel:11232121234\">1 123 212-1234</a>" +
                "</body></html>" },
            { "USA", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1232121234\">123-212-1234</a>" +
                "<a href=\"tel:2121234\">212-1234</a>" +
                "<a href=\"tel:11232121234\">1-123-212-1234</a>" +
                "<a href=\"tel:11232121234\">1 123 212-1234</a>" +
                "</body></html>" },
            { "MEX", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1231212\">123 12 12</a>" +
                "<a href=\"tel:12341234\">1234 1234</a>" +
                "<a href=\"tel:121212341234\">(12) 12 1234 1234</a>" +
                "<a href=\"tel:121212341234\">(12 12) 1234 1234</a>" +
                "<a href=\"tel:1212341234\">(12) 1234 1234</a>" +
                "<a href=\"tel:1234567890\">1234567890</a>" +
                "<a href=\"tel:1212341234\">12 1234 1234</a>" +
                "<a href=\"tel:1231231234\">123 123 1234</a>" +
                "<a href=\"tel:1231231212\">123 123 12 12</a>" +
                "<a href=\"tel:1231231231234\">(123) 123 123 1234</a>" +
                "<a href=\"tel:1231231231212\">(123) 123 123 12 12</a>" +
                "<a href=\"tel:1231212341234\">(123) 12 1234 1234</a>" +
                "</body></html>" },
            { "BEL", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:012121212\">012 12 12 12</a>" +
                "<a href=\"tel:011231212\">01 123 12 12</a>" +
                "<a href=\"tel:0412121212\">0412 12 12 12</a>" +
                "<a href=\"tel:0412123123\">0412 123 123</a>" +
                "<a href=\"tel:012121212\">012/12 12 12</a>" +
                "<a href=\"tel:012121212\">012/12.12.12</a>" +
                "<a href=\"tel:0412121212\">0412/12 12 12</a>" +
                "<a href=\"tel:0412121212\">0412/12.12.12</a>" +
                "<a href=\"tel:0412123123\">0412/123.123</a>" +
                "<a href=\"tel:+32412121212\">+32 412 12 12 12</a>" +
                "</body></html>" },
            { "DNK", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:12121212\">12 12 12 12</a>" +
                "<a href=\"tel:12341234\">1234 1234</a>" +
                "<a href=\"tel:12123123\">12 123 123</a>" +
                "<a href=\"tel:12345678\">12345678</a>" +
                "</body></html>" },
            { "FR", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:0112121212\">01 12 12 12 12</a>" +
                "<a href=\"tel:+33112121212\">+33 1 12 12 12 12</a>" +
                "</body></html>" },
            { "GRC", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1231234567\">123 1234567</a>" +
                "<a href=\"tel:1234123456\">1234 123456</a>" +
                "<a href=\"tel:+301231234567\">+30 123 1234567</a>" +
                "<a href=\"tel:+301234123456\">+30 1234 123456</a>" +
                "</body></html>" },
            { "ISL", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1231234\">123 1234</a>" +
                "<a href=\"tel:1231234\">123-1234</a>" +
                "</body></html>" },
            { "IRL", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:011231234\">01 123 1234</a>" +
                "<a href=\"tel:0121231234\">012 123 1234</a>" +
                "<a href=\"tel:012123123\">012 123 123</a>" +
                "<a href=\"tel:12312345\">123 12345</a>" +
                "<a href=\"tel:1234121212\">1234 12 12 12</a>" +
                "</body></html>" },
            { "NL", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:0121234567\">012-1234567</a>" +
                "<a href=\"tel:0123123456\">0123-123456</a>" +
                "<a href=\"tel:0612345678\">06-12345678</a>" +
                "<a href=\"tel:+311212345678\">+31 12 12345678</a>" +
                "<a href=\"tel:+31612345678\">+31 6 12345678</a>" +
                "</body></html>" },
            { "NOR", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:12121212\">12 12 12 12</a>" +
                "<a href=\"tel:12312123\">123 12 123</a>" +
                "</body></html>" },
            { "PL", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:123123123\">123-123-123</a>" +
                "<a href=\"tel:121231212\">12-123-12-12</a>" +
                "<a href=\"tel:121231212\">(12) 123-12-12</a>" +
                "</body></html>" },
            { "ROU", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:123123123\">123-123-123</a>" +
                "<a href=\"tel:1231231212\">123-123-12-12</a>" +
                "</body></html>" },
            { "RUS", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:1231212\">123-12-12</a>" +
                "<a href=\"tel:121212\">12-12-12</a>" +
                "<a href=\"tel:11212\">1-12-12</a>" +
                "<a href=\"tel:1231231212\">(123) 123-12-12</a>" +
                "<a href=\"tel:1234121212\">(1234) 12-12-12</a>" +
                "<a href=\"tel:1234511212\">(12345) 1-12-12</a>" +
                "<a href=\"tel:81231231212\">8 (123) 123-12-12</a>" +
                "<a href=\"tel:+71231231212\">+7 (123) 123-12-12</a>" +
                "<a href=\"tel:81231231212\">8 123 123-12-12</a>" +
                "<a href=\"tel:+71231231212\">+7 123 123 12 12</a>" +
                "</body></html>" },
            { "ESP", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:123123123\">123 123 123</a>" +
                "<a href=\"tel:121231212\">12 123 12 12</a>" +
                "<a href=\"tel:123121212\">123 12 12 12</a>" +
                "</body></html>" },
            { "CHE", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:0121231212\">012 123 12 12</a>" +
                "<a href=\"tel:+41121231212\">+41 12 123 12 12</a>" +
                "<a href=\"tel:1234123123\">1234 123 123</a>" +
                "</body></html>" },
            { "GBR", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:123412341234\">(1234) 1234 1234</a>" +
                "<a href=\"tel:12341231234\">(1234) 123 1234</a>" +
                "<a href=\"tel:1234512345\">(12345) 12345</a>" +
                "<a href=\"tel:12345123456\">(12345) 123456</a>" +
                "<a href=\"tel:1234121234\">(1234 12) 1234</a>" +
                "<a href=\"tel:12341212345\">(1234 12) 12345</a>" +
                "<a href=\"tel:12341231234\">1234 123 1234</a>" +
                "<a href=\"tel:12341231234\">1234-123 1234</a>" +
                "</body></html>" },
            { "MISC", "<!DOCTYPE html><html><head><title>Sample HTML</title></head><body><h1>Sample</h1>" +
                "<a href=\"tel:01212341234\">(012) 1234-1234</a>" +
                "<a href=\"tel:012312341234\">(0123) 1234-1234</a>" +
                "<a href=\"tel:031234121234\">(031234) 12-1234</a>" +
                "<a href=\"tel:012341231234\">(01234) 123-1234</a>" +
                "<a href=\"tel:01012\">01012</a>" +
                "<a href=\"tel:010012\">010012</a>" +
                "<a href=\"tel:01212123456789\">01212-123456789</a>" +
                "<a href=\"tel:01371231234567\">0137-123 1234567</a>" +
                "<a href=\"tel:01381123456\">0138-1123456</a>" +
                "<a href=\"tel:015121234567\">01512-1234567</a>" +
                "<a href=\"tel:01611234567\">0161-1234567</a>" +
                "<a href=\"tel:01711234567\">0171-1234567</a>" +
                "<a href=\"tel:01812123456789\">01812-123456789</a>" +
                "<a href=\"tel:018123456712\">0181234567-12</a>" +
                "<a href=\"tel:01801234567\">0180-1234567</a>" +
                "<a href=\"tel:018112312345\">0181-123-12345</a>" +
                "<a href=\"tel:0181123412345\">0181-1234-12345</a>" +
                "<a href=\"tel:12341234567\">1234-1234567</a>" +
                "<a href=\"tel:1231234567\">123-1234567</a>" +
                "<a href=\"tel:12341123456\">1234-1-123456</a>" +
                "<a href=\"tel:12312121\">123 - 12 12 - 1</a>" +
                "<a href=\"tel:12312121212\">123 - 12 12 - 12 12</a>" +
                "<a href=\"tel:01234123456\">01234 123456</a>" +
                "<a href=\"tel:0123412345612\">01234 123456-12</a>" +
                "<a href=\"tel:+491234123456\">+49 1234 123456</a>" +
                "<a href=\"tel:01234123456\">(01234) 123456</a>" +
                "<a href=\"tel:+491234123456\">+49 1234 123456</a>" +
                "<a href=\"tel:+491234123456\">+49 (1234) 123456</a>" +
                "<a href=\"tel:01234123456\">01234-123456</a>" +
                "<a href=\"tel:0123412345612\">01234/123456-12</a>" +
                "<a href=\"tel:123411212123\">1234 / 1 12 12 123</a>" +
                "<a href=\"tel:12341212123\">1234 / 12 12 123</a>" +
                "<a href=\"tel:12345/1231\">12345/123-1</a>" +
                "<a href=\"tel:123451231\">12345/123-1</a>" +
                "<a href=\"tel:1234512312\">12345/123-12</a>" +
                "<a href=\"tel:12345123123\">12345/123-123</a>" +
                "<a href=\"tel:1121212121\">(1 12 12) 12 12 - 1</a>" +
                "<a href=\"tel:11212121212\">(1 12 12) 12 12 - 12</a>" +
                "<a href=\"tel:112121212123\">(1 12 12) 12 12 - 123</a>" +
                "</body></html>" }
        };

        public static readonly Dictionary<string, List<string>> ExpectedRegexResults = new Dictionary<string, List<string>>()
        {
            { "GER", new List<string>()
                {
                    "01234 123456",
                    "01234-123456",
                    "01234/123456",
                    "01234/123456-12",
                    "(01234) 123456",
                    "01234 123456-12",
                    "+49 1234 123456",
                    "+49 (1234) 123456",
                    "1234 - 12 12 12 12",
                    "+49 8 91 23 45-67",
                    "+49 89 1 23 45-67",
                    "+49 (89) 1 23 45-67",
                    "+49 (0 89) 74 85 64-0",
                    "+49 (089) 748564-0",
                    "+49 (0) 89 74 85 64-0",
                    "+49 (05132) 6688",
                    "+49 (5132) 6688",
                    "+ 49 12 12 / 12 12 - 12 12",
                    "+49 12 12 / 12 12 - 12 12",
                    "+33 (0) 296 14 11 33",
                    "+33 296 14 11 33",
                    "+49 511 5352-0",
                    "+49 30 6290111-0",
                    "040 - 64 61 - 0",
                    "+49 (0)221 - 177 39 777",
                    "(0 21 61) 49 04 - 0",
                    "0800 / 5 03 54 18",
                    "0800 / 33 00 556",
                    "(040) 63 77 - 0",
                    "0800 - 43 53 361",
                    "040 38080-0",
                    "(040) 3280-0",
                    "+49 241 80 1",
                }
            },
            { "CA", new List<string>()
                {
                    "123-212-1234",
                    "212-1234",
                    "1-123-212-1234",
                    "1 123 212-1234",
                }
            },
            { "USA", new List<string>()
                {
                    "123-212-1234",
                    "212-1234",
                    "1-123-212-1234",
                    "1 123 212-1234",
                }
            },
            { "MEX", new List<string>()
                {
                    "123 12 12",
                    "1234 1234",
                    "(12) 12 1234 1234",
                    "(12 12) 1234 1234",
                    "(12) 1234 1234",
                    "1234567890",
                    "12 1234 1234",
                    "123 123 1234",
                    "123 123 12 12",
                    "(123) 123 123 1234",
                    "(123) 123 123 12 12",
                    "(123) 12 1234 1234",
                }
            },
            { "BEL", new List<string>()
                {
                    "012 12 12 12",
                    "01 123 12 12",
                    "0412 12 12 12",
                    "0412 123 123",
                    "012/12 12 12",
                    "012/12.12.12",
                    "0412/12 12 12",
                    "0412/12.12.12",
                    "0412/123.123",
                    "+32 412 12 12 12",
                }
            },
            { "DNK", new List<string>()
                {
                    "12 12 12 12",
                    "1234 1234",
                    "12 123 123",
                    "12345678",
                }
            },
            { "FR", new List<string>()
                {
                    "01 12 12 12 12",
                    "+33 1 12 12 12 12",
                }
            },
            { "GRC", new List<string>()
                {
                    "123 1234567",
                    "1234 123456",
                    "+30 123 1234567",
                    "+30 1234 123456",
                }
            },
            { "ISL", new List<string>()
                {
                    "123 1234",
                    "123-1234",
                }
            },
            { "IRL", new List<string>()
                {
                    "01 123 1234",
                    "012 123 1234",
                    "012 123 123",
                    "123 12345",
                    "1234 12 12 12",
                }
            },
            { "NL", new List<string>()
                {
                    "012-1234567",
                    "0123-123456",
                    "06-12345678",
                    "+31 12 12345678",
                    "+31 6 12345678",
                }
            },
            { "NOR", new List<string>()
                {
                    "12 12 12 12",
                    "123 12 123",
                }
            },
            { "PL", new List<string>()
                {
                    "123-123-123",
                    "12-123-12-12",
                    "(12) 123-12-12",
                }
            },
            { "ROU", new List<string>()
                {
                    "123-123-123",
                    "123-123-12-12",
                }
            },
            { "RUS", new List<string>()
                {
                    "123-12-12",
                    "12-12-12",
                    "1-12-12",
                    "(123) 123-12-12",
                    "(1234) 12-12-12",
                    "(12345) 1-12-12",
                    "8 (123) 123-12-12",
                    "+7 (123) 123-12-12",
                    "8 123 123-12-12",
                    "+7 123 123 12 12",
                }
            },
            { "ESP", new List<string>()
                {
                    "123 123 123",
                    "12 123 12 12",
                    "123 12 12 12",
                }
            },
            { "CHE", new List<string>()
                {
                    "012 123 12 12",
                    "+41 12 123 12 12",
                    "1234 123 123",
                }
            },
            { "GBR", new List<string>()
                {
                    "(1234) 1234 1234",
                    "(1234) 123 1234",
                    "(12345) 12345",
                    "(12345) 123456",
                    "(1234 12) 1234",
                    "(1234 12) 12345",
                    "1234 123 1234",
                    "1234-123 1234",
                }
            },
            { "MISC", new List<string>()
                {
                    "(012) 1234-1234",
                    "(0123) 1234-1234",
                    "(01234) 123-1234",
                    "(031234) 12-1234",
                    "01012",
                    "010012",
                    "01212-123456789",
                    "0137-123 1234567",
                    "0138-1123456",
                    "01512-1234567",
                    "0161-1234567",
                    "0171-1234567",
                    "01812-123456789",
                    "0181234567-12",
                    "0180-1234567",
                    "0181-123-12345",
                    "0181-1234-12345",
                    "1234-1234567",
                    "123-1234567",
                    "1234-1-123456",
                    "123 - 12 12 - 1",
                    "123 - 12 12 - 12 12",
                    "01234 123456",
                    "01234 123456-12",
                    "+49 1234 123456",
                    "(01234) 123456",
                    "+49 1234 123456",
                    "+49 (1234) 123456",
                    "01234-123456",
                    "01234/123456-12",
                    "1234 / 1 12 12 123",
                    "1234 / 12 12 123",
                    "12345/123-1",
                    "12345/123-12",
                    "12345/123-123",
                    "(1 12 12) 12 12 - 1",
                    "(1 12 12) 12 12 - 12",
                    "(1 12 12) 12 12 - 123", }
            }
        };

        public static readonly Dictionary<string, List<string>> ExpectedResultsSimple = new Dictionary<string, List<string>>()
        {
            { "GER",new List<string>
                {
                    "01234123456",
                    "01234123456",
                    "01234123456",
                    "01234123456",
                    "0123412345612",
                    "0123412345612",
                    "+491234123456",
                    "+491234123456",
                    "123412121212",
                    "+49891234567",
                    "+49891234567",
                    "+49891234567",
                    "+490897485640",
                    "+490897485640",
                    "+490897485640",
                    "+49051326688",
                    "+4951326688",
                    "+49121212121212",
                    "+49121212121212",
                    "+330296141133",
                    "+33296141133",
                    "+4951153520",
                    "+493062901110",
                    "+04064610",
                    "+49022117739777",
                    "0216149040",
                    "08005035418",
                    "08003300556",
                    "04063770",
                    "08004353361",
                    "040380800",
                    "04032800",
                    "+49241801",
                }
            },
            { "CA", new List<string>
                {
                    "1232121234",
                    "2121234",
                    "11232121234",
                    "11232121234",
                }
            },
            { "USA",new List<string>
                {
                    "1232121234",
                    "2121234",
                    "11232121234",
                    "11232121234",
                }
            },
            { "MEX",new List<string>
                {
                    "1231212",
                    "12341234",
                    "121212341234",
                    "121212341234",
                    "1212341234",
                    "1234567890",
                    "1212341234",
                    "1231231234",
                    "1231231212",
                    "1231231231234",
                    "1231231231212",
                    "1231212341234",
                }
            },
            { "BEL",new List<string>
                {
                    "012121212",
                    "011231212",
                    "0412121212",
                    "0412123123",
                    "012121212",
                    "012121212",
                    "0412121212",
                    "0412121212",
                    "0412123123",
                    "+32412121212",
                }
            },
            { "DNK",new List<string>
                {
                    "12121212",
                    "12341234",
                    "12123123",
                    "12345678",
                }
            },
            { "FR",new List<string>
                {
                    "0112121212",
                    "+33112121212",
                }
            },
            { "GRC",new List<string>
                {
                    "1231234567",
                    "1234123456",
                    "+301231234567",
                    "+301234123456",
                }
            },
            { "ISL",new List<string>
            {
                "1231234",
                "1231234",
            }
            },
            { "IRL",new List<string>
                {
                    "011231234",
                    "0121231234",
                    "012123123",
                    "12312345",
                    "1234121212",
                }
            },
            { "NL",new List<string>
                {
                    "0121234567",
                    "0123123456",
                    "0612345678",
                    "+311212345678",
                    "+31612345678",
                }
            },
            { "NOR",new List<string>
                {
                    "12121212",
                    "12312123",
                }
            },
            { "PL",new List<string>
                {
                    "123123123",
                    "121231212",
                    "121231212",
                }
            },
            { "ROU",new List<string>
                {
                    "123123123",
                    "1231231212",
                }
            },
            { "RUS",new List<string>
                {
                    "1231212",
                    "121212",
                    "11212",
                    "1231231212",
                    "1234121212",
                    "1234511212",
                    "81231231212",
                    "+71231231212",
                    "81231231212",
                    "+71231231212",
                }
            },
            { "ESP",new List<string>
                {
                    "123123123",
                    "121231212",
                    "123121212",
                }
            },
            { "CHE",new List<string>
                {
                    "0121231212",
                    "+41121231212",
                    "1234123123",
                }
            },
            { "GBR",new List<string>
                {
                    "123412341234",
                    "12341231234",
                    "1234512345",
                    "12345123456",
                    "1234121234",
                    "12341212345",
                    "12341231234",
                    "12341231234",
                }
            },
            { "MISC",new List<string>
                {
                    "01212341234",
                    "012312341234",
                    "012341231234",
                    "031234121234",
                    "01012",
                    "010012",
                    "01212123456789",
                    "01371231234567",
                    "01381123456",
                    "015121234567",
                    "01611234567",
                    "01711234567",
                    "01812123456789",
                    "018123456712",
                    "01801234567",
                    "018112312345",
                    "0181123412345",
                    "12341234567",
                    "1231234567",
                    "12341123456",
                    "12312121",
                    "12312121212",
                    "01234123456",
                    "0123412345612",
                    "+491234123456",
                    "01234123456",
                    "+491234123456",
                    "+491234123456",
                    "01234123456",
                    "0123412345612",
                    "123411212123",
                    "12341212123",
                    "123451231",
                    "1234512312",
                    "12345123123",
                    "1121212121",
                    "11212121212",
                    "112121212123",
                }
            }
        };
    }
}
