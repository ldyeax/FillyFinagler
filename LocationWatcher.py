import os
import time
import sys
import json
import winreg
import threading

regpath = r"Software\BitGames\Anonfilly"

regconnection = winreg.ConnectRegistry(None, winreg.HKEY_CURRENT_USER)
rootkey = winreg.OpenKey(regconnection, regpath)

savenames = [r"save_save1_h1476750443", r"save_save2_h1476750440", r"save_save3_h1476750441"]

filename = "locations.json"

def add_stage(locations, stage, entrance):
    ret = False
    if stage not in locations:
        locations[stage] = []
        ret = True
    if entrance not in locations[stage]:
        locations[stage].append(entrance)
        ret = True
    return ret

def watch(savename):
    filename = "locationwatcher__" + savename + ".json"
    if not os.path.isfile(filename):
        open(filename, "w").write("{}")
    locations = json.load(open(filename, "r"))
    while True:
        try:
            q = winreg.QueryValueEx(rootkey, savename)
            if q is None:
                pass
            if q[0] is None or len(q[0]) < 1:
                pass
            bdata = q[0]
            if bdata[-1] == 0:
                bdata = bdata[:-1]
            asciidata = bdata.decode("ascii")
            jsondata = json.loads(asciidata)
            if add_stage(locations, jsondata["stage"], jsondata["entrance"]):
                json.dump(locations, open(filename, "w"), indent="\t")
        except:
            pass
        time.sleep(1)

threads = []

for savename in savenames:
    t = threading.Thread(target=watch, args=(savename,))
    t.start()
    threads.append(t)

while True:
    time.sleep(1)