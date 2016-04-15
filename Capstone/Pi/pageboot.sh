
xte 'sleep 10' 'key F11'&
MAC=$(cat /sys/class/net/eth0/address)
epiphany-browser "www.google.com/"$MAC