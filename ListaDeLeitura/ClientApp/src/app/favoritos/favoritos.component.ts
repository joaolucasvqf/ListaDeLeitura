import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { MyDialogComponent } from '../my-dialog/my-dialog.component';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-favoritos-component',
  templateUrl: './favoritos.component.html'
})
export class FavoritosComponent {
  livrosList: livros[] = [];
  title = "Remover livro";

  constructor(
    private http: HttpClient, 
    @Inject('BASE_URL') private baseUrl: string,
    public dialog: MatDialog,
    private toastr: ToastrService,
    ){ 
  }

  RemoverLivro(livro: livros){
    var confirmacao = this.dialog.open(MyDialogComponent);
    confirmacao.afterClosed().subscribe(result => {
      if (result){
        this.http.delete(this.baseUrl + 'api/Livros/' + livro.id).subscribe(result => {
          console.log("Livro removido com sucesso.");
          this.livrosList.splice(this.livrosList.indexOf(livro), 1);
          this.toastr.success("Livro removido com sucesso!");
        }, error => console.error(error));
      }
    })
  }

  ngOnInit(){
    this.http.get<livros[]>(this.baseUrl + 'api/Livros/Favoritos').subscribe(result => {
      this.livrosList = result;
    }, error => console.error(error));
  }
}

interface livros {
  id: string;
  etag: string;
  thumbnail: string;
  title: string;
  authors: string[];
  description: string;
}
