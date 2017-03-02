<!DOCTYPE html>
<html>
<link href="{{ asset('/css/style.css') }}" rel="stylesheet">
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
  
	<?php

	$oeuvres = DB::table('OeuvreParSondage')->wheresondage_id($n)->get();

	echo'<table class="tab">';
	    echo'<br>';
	    echo'<caption class="captiontab"><h1>Liste des oeuvres </h1></caption>';
    	echo'<tr class="trtab">';
    		echo'<th class="thtab">Titre</th>';
    		echo'<th class="thtab">Auteur</th>';
    		echo'<th class="thtab">Voir plus</th>';
  		echo'</tr>';
	foreach ($oeuvres as $oeuvre) {
		echo'<tr class="trtab">';
			echo'<td class="tdtab">';
	    		echo $oeuvre->titre;
	    	echo'</td>';
	    	echo'<td class="tdtab">';
	    		echo $oeuvre->auteur;
	    	echo'</td>';
	        echo'<td class="tdtab">';	
	    		echo "<a href='../oeuvre/$oeuvre->id'>Voir plus</a>";
	    	echo'</td>';
	    echo'</tr>';	
	}
	echo'</table>';
	?>
@stop	
</html>