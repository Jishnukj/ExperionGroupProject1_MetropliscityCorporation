import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowactComponent } from './showact.component';

describe('ShowactComponent', () => {
  let component: ShowactComponent;
  let fixture: ComponentFixture<ShowactComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowactComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
