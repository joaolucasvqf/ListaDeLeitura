import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  livrosList: livros[] = [];
  searchText: string = '';

  constructor(
    private http: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string, 
    private toastr: ToastrService
    ){ 
  }

  PesquisarLivros() {
    if (this.searchText.length > 0){
      this.http.get<livros[]>(this.baseUrl + 'api/Livros/' + this.searchText).subscribe(result => {
        this.livrosList = result;
      }, error => console.error(error));
    }
  }

  onClickButton(livro){
    this.http.post(this.baseUrl + 'api/Livros', livro).subscribe(result => {
      livro.favorito = true;
      console.log("Sucesso");
      this.toastr.success("Livro adicionado aos favoritos!", "")
    }, error => {
      console.error(error);
      this.toastr.error("Oops, tivemos alguns problemas ao adicionar seu livro à lista de favoritos, tente novamente!", "")
    });
  }
}


interface livros {
  id: string;
  etag: string;
  thumbnail: string;
  title: string;
  authors: string[];
  description: string;
  favorito: boolean;
}
