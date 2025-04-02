function startJob(path, id, id2) {
  var xhttp = new XMLHttpRequest();
  xhttp.onreadystatechange = function() {
    if (this.readyState == 4 && this.status == 200) {
		document.getElementById(id).style.visibility = "visible";
		document.getElementById(id2).style.visibility = "hidden";
		var jobid = this.responseText;
	 
		setInterval(function(){
			var that = this;
			var x = new XMLHttpRequest();
			x.onreadystatechange = function() {
				if (this.readyState == 4 && this.status == 200) {
					document.getElementById(id).style.visibility = "hidden";
					document.getElementById(id2).style.visibility = "visible";
					document.getElementById(id2).innerHTML="<a href=/api/result?path=/data/"+jobid+">RESULT</a>";
					clearInterval(that);
				}
			};
			x.open("GET", "/api/complete?path=/data/"+jobid, true);
			x.send();
		},5000);
    }
  };
  xhttp.open("GET", "/api/startone?test="+path, true);
  xhttp.send();  
}

