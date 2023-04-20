""" 
Cameron Pilchard
CIS 560

The following code is purposed to extract every week in the Billboard 200.
"""

import billboard
from datetime import datetime

start_date = datetime.strptime('2022-01-01', "%Y-%m-%d")
end_date = datetime.strptime('2021-01-01', "%Y-%m-%d")
"""
start_date = {
    'year': 1963, 
    'month': 8, 
    'day': 17
}
"""

def getNumDaysInMonth(date):
    month = date.month
    year = date.year
    if (month == 2):
        if (((year % 4 == 0) and (not date.year % 100 == 0)) or (year % 400 == 0)):
            return 29
        else:
            return 28
    if (
        (month == 1)
        or (month == 3)
        or (month == 5)
        or (month == 7)
        or (month == 8)
        or (month == 10)
        or (month == 12)
        ):
        return 31
    else:
        return 30
    
"""
def getNextWeekDate: gets the next week after a given date. loops with conditions based on the weird way our current calendar system works
returns: dictionary of new date one week after the old one
"""
def getNextWeekDate(old_date):
    
    new_day = old_date.day + 7 
    new_month = old_date.month
    new_year = old_date.year

    numDaysInMonth = getNumDaysInMonth(old_date)
    if (new_day > numDaysInMonth):
        new_day -= numDaysInMonth
        new_month += 1
        if (new_month > 12):
            new_year += (new_month // 12)
            new_month = new_month % 12
    
    return datetime(new_year, new_month, new_day, 0, 0, 0)

"""
def lazy: returns true when the next bool in sequence is true
*args: every bool in the expr
"""
def lazy(*args):
    for arg in args:
        if not arg:
            continue
        return True
    return False



"""
chart = billboard.ChartData('billboard-200', '1963-08-24')

print(chart)
"""

################################################################################################################
################################################################################################################
# Here is where the main code is executed

import ntpath
import easygui
import pandas as pd
import openpyxl

xlsxFilePath = None
sheetTitle = "data dump"

def exitPrompt():
    if easygui.boolbox("You pressed cancel. Would you like to exit the program?", "Exit?", ["Yes", "No"]):
        return False
    else:
        return True

def saveFile():
    flag = True

    while flag:
        try:
            xlsxFilePath = easygui.filesavebox(default="*.xlsx",filetypes=["*.xlsx"])
            while xlsxFilePath is None:
                if exitPrompt():
                    xlsxFilePath = easygui.filesavebox(default="*.xlsx",filetypes=["*.xlsx"])
                else:
                    exit()

            if not ntpath.isfile(xlsxFilePath):
                workbook = openpyxl.Workbook()
                sheet = workbook.active
                sheet.title = ntpath.basename(sheetTitle)
                workbook.save(xlsxFilePath)
            with pd.ExcelWriter(xlsxFilePath, mode='a', engine='openpyxl', if_sheet_exists='replace') as writer:
                
                date = start_date
                numWeeks = 0
                num = 1
                condition = lazy(date.year < end_date.year, date.month < end_date.month, date.day <= end_date.day)
                while (condition):
                    dates = []
                    ranks = []
                    albums = []
                    artists = []
                    for i in range(200): #lazy interpretation
                        if (condition):
                            numWeeks += 1
                            print(date.strftime("%Y-%m-%d"))
                            chartData = billboard.ChartData('billboard-200', date.strftime("%Y-%m-%d"))
                            for chartEntry in chartData:
                                dates.append(date.strftime("%Y-%m-%d"))
                                
                                ranks.append(chartEntry.rank)
                                albums.append(chartEntry.title)
                                artists.append(chartEntry.artist)
                            date = getNextWeekDate(date)
                    df = pd.DataFrame(data={'date': dates, 'rank': ranks, 'album': albums, 'artist': artists}, index=range(1,len(dates)+1))
                    df.to_excel(writer, sheet_name=ntpath.basename(sheetTitle+str(num)))
                    num += 1
            easygui.msgbox("Successfully extracted {} weeks, can be found at: \n{}\n".format(numWeeks, xlsxFilePath), "Success")
            flag = False
        except PermissionError:
            easygui.msgbox("ERROR!\nPlease close out of the Excel sheet {}. \nThe titles cannot be added if the excel sheet you are saving to is currently open.\n".format(ntpath.basename(xlsxFilePath)), "Error")

if __name__ == "__main__":
    print(lazy(3 < 2, 5< 3, 6< 4))
    easygui.msgbox("Ok, so to run the program you will do the following: \n1. Then you will be prompted save/export those titles into an excel sheet.", "INSTRUCTIONS")
    
    saveFile()