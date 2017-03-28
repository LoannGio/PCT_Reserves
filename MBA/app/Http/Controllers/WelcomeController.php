<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
use App\Http\Requests;
use App\Http\Controllers\Controller;

class WelcomeController extends Controller
{
    public function index()
    {
        return view('welcome');
    }
    public function sondage($n)
    {
    	return view('sondage')->with('n',$n);
    }
    public function oeuvres($n)
    {
    	return view('oeuvres')->with('n',$n);	
    }
    public function oeuvre($s_id,$o_id)
    {
    	return view('oeuvre')->with(compact('s_id', 'o_id'));	
    }
    public function voter($s_id,$o_id)
    {
    	return view('voter')->with(compact('s_id', 'o_id'));
    }

    public function remercie()
    {
        return view('remercie');
    }

    public function error()
    {
        return view('error');
    }
     
}