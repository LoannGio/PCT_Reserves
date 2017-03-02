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

$sondage = DB::table('Sondage')->whereid($n)->first();
echo $sondage->titre, '<br>';
echo $sondage->description, '<br>';
echo $sondage->date_debut, '<br>';
echo $sondage->date_fin, '<br>';
echo "<a href='../oeuvres/$sondage->id'>Listes d'oeuvres</a>";


?>

@stop	
</html>
