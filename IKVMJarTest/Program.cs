using cn.hutool.core.date;
using cn.hutool.core.util;
using com.spire.xls;


var te1 = 123456.123456;
var te2 = 123456.128456;
Console.WriteLine(NumberUtil.round(te1, 4)); //结果:123456.1235
Console.WriteLine(NumberUtil.round(te2, 3)); //结果:123456.128

var localDateTime = LocalDateTimeUtil.parse("2020-01-23T12:23:56");

// "2020-01-23 12:23:56"
var format = LocalDateTimeUtil.format(localDateTime, DatePattern.NORM_DATETIME_PATTERN);

Console.WriteLine(format); //结果:123456.128

com.spire.xls.Workbook spireXlsWorkbook = new com.spire.xls.Workbook();
spireXlsWorkbook.loadFromFile(@"C:\Users\xkz19\Desktop\WLG-模造IPQC-2H-1664172600044.xlsx");
Worksheet worksheet = spireXlsWorkbook.getWorksheets().get(0);
worksheet.saveToImage(@"C:\Users\xkz19\Desktop\WLG-模造IPQC-2H-1664172600044.png");