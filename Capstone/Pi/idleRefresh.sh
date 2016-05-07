TIMEOUT=$((5*60*1000))

command(){
	sh /home/pi/pageboot.sh
}

sleep_time=$IDLE_TIME
triggered=false

while sleep$(((sleep_time+999)/1000)); do
	idle=$(xprintidle)
	if [ $idle -ge $TIMEOUT ]; then
		if ! $triggered; then
			command
			triggered=true;
			sleep_time=$TIMEOUT
		fi
	else
		triggered=false
		sleep_time=$((TIMEOUT-idle+100))
	fi
done